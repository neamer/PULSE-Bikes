using PULSE.Model;

namespace PULSE.Services.Interfaces
{
  public interface IRecommendationService
  {
    public List<ProductAIO> GetSimilarProducts(int id);
  }
}