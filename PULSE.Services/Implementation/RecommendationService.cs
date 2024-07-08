using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;
using PULSE.Services.Utils;

namespace PULSE.Services.Implementation
{
  public class RecommendationService : IRecommendationService
  {
    public PULSEContext Context { get; set; }
    public IMapper Mapper { get; set; }


    static MLContext mlContext = null;
    static object isLocked = new object();
    static ITransformer model = null;

    private IBicycleService BicycleService { get; }
    private IGearService GearService { get; }
    private IPartService PartService { get; }



    public RecommendationService(PULSEContext context, IMapper mapper, IBicycleService bicycleService,
            IGearService gearService,
            IPartService partService)
    {
      Context = context;
      Mapper = mapper;
      BicycleService = bicycleService;
      GearService = gearService;
      PartService = partService;
    }

    public List<Model.ProductAIO> GetSimilarProducts(int id)
    {
      lock (isLocked)
      {
        if (mlContext == null)
        {
          mlContext = new MLContext();

          model = TrainModel(GetProductEntries());
        }
      }

      var products = Context.Products.Where(x => x.Id != id);

      var predictionResult = new List<Tuple<Data.Product, float>>();

      foreach (var product in products)
      {
        var predictionEngine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);

        var prediction = predictionEngine.Predict(new ProductEntry()
        {
          ProductID = (uint)id,
          CoPurchaseProductID = (uint)product.Id
        });

        predictionResult.Add(new Tuple<Data.Product, float>(product, prediction.Score));
      }

      var finalResult = predictionResult.OrderByDescending(x => x.Item2).Select(x => x.Item1).Take(3).ToList();

      return MapEnrichedResults(finalResult);
    }

    private List<ProductEntry> GetProductEntries()
    {

      var orders = Context.OrderHeaders.Include(o => o.OrderDetails).ToList();

      var data = new List<ProductEntry>();

      foreach (var order in orders)
      {
        if (order.OrderDetails.Count > 1)
        {
          var distinctItemIds = order.OrderDetails.Select(item => item.ProductId).ToList();

          distinctItemIds.ForEach(distinctItemId =>
          {
            var relatedItems = order.OrderDetails.Where(item => item.ProductId != distinctItemId);

            foreach (var relatedItem in relatedItems)
            {
              data.Add(new ProductEntry()
              {
                ProductID = (uint)distinctItemId,
                CoPurchaseProductID = (uint)relatedItem.ProductId,
              });
            }
          });
        }
      }

      return data;
    }

    private ITransformer TrainModel(List<ProductEntry> data)
    {
      var trainData = mlContext.Data.LoadFromEnumerable(data);

      var options = new MatrixFactorizationTrainer.Options()
      {
        MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID),
        MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID),
        LabelColumnName = nameof(ProductEntry.Label),
        LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass,
        Alpha = 0.01,
        Lambda = 0.025,
        NumberOfIterations = 10,
        C = 0.00001
      };

      var matrixFactorizationTrainer = mlContext.Recommendation().Trainers.MatrixFactorization(options);

      return matrixFactorizationTrainer.Fit(trainData);
    }

    private List<Model.ProductAIO> MapEnrichedResults(List<Product> results)
    {
      var finalResults = new List<Model.ProductAIO>();

      foreach (var result in results)
      {
        if (result.Discriminator == "Bicycle")
        {
          finalResults.Add(Mapper.Map<Model.ProductAIO>(this.BicycleService.GetById(result.Id, IncludeAll.Bicycle)));
        }
        else if (result.Discriminator == "Gear")
        {
          finalResults.Add(Mapper.Map<Model.ProductAIO>(this.GearService.GetById(result.Id, IncludeAll.Gear)));
        }
        else if (result.Discriminator == "Part")
        {
          finalResults.Add(Mapper.Map<Model.ProductAIO>(this.PartService.GetById(result.Id, IncludeAll.Part)));
        }
      }

      return finalResults;
    }
  }

  public class Copurchase_prediction
  {
    public float Score { get; set; }
  }

  public class ProductEntry
  {
    // [KeyType(count: int.MaxValue)]
    [KeyType(count: 10000)]
    public uint ProductID { get; set; }

    // [KeyType(count: int.MaxValue)]
    [KeyType(count: 10000)]
    public uint CoPurchaseProductID { get; set; }

    public float Label { get; set; }
  }
}
