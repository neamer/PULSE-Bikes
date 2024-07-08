
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PULSE.Model;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Services.Implementation
{
  public class StatsService : IStatsService
  {
    public PULSEContext Context { get; set; }
    public IMapper Mapper { get; set; }

    public StatsService(PULSEContext context, IMapper mapper)
    {
      Context = context;
      Mapper = mapper;
    }

    public List<MonthlyStats> GetRevenuePerMonth(int year)
    {
      return Context.OrderDetail
          .Include(item => item.Order)
          .Where(item => item.Order.TimeProcessed.HasValue && item.Order.TimeProcessed.Value.Year == year)
          .GroupBy(item => new { item.Order.TimeProcessed.Value.Year, item.Order.TimeProcessed.Value.Month })
            .Select(group => new MonthlyStats
            {
              Year = group.Key.Year,
              Month = group.Key.Month,
              Value = group.Sum(detail => detail.Quantity * detail.UnitPrice)
            })
          .OrderBy(result => result.Year)
          .ThenBy(result => result.Month)
          .ToList();
    }

    public List<MonthlyStats> GetSalesPerMonth(int year)
    {
      return Context.OrderDetail
          .Include(item => item.Order)
          .Where(item => item.Order.TimeProcessed.HasValue && item.Order.TimeProcessed.Value.Year == year)
          .GroupBy(item => new { item.Order.TimeProcessed.Value.Year, item.Order.TimeProcessed.Value.Month })
            .Select(group => new MonthlyStats
            {
              Year = group.Key.Year,
              Month = group.Key.Month,
              Value = group.Sum(detail => detail.Quantity)
            })
          .OrderBy(result => result.Year)
          .ThenBy(result => result.Month)
          .ToList();
    }

    public List<BicycleCategoryStats> GetBicycleSalesPerType()
    {
      return Context.OrderDetail
          .Include(item => item.Order)
          .Include(item => item.Product)
          .Where(item => item.Order.TimeProcessed.HasValue && item.Discriminator == ProductDiscriminator.Bicycle)
          .GroupBy(item => new { item.Product.ProductCategoryId })
            .Select(group => new BicycleCategoryStats
            {
              CategoryId = group.Key.ProductCategoryId,
              Value = group.Sum(detail => detail.Quantity)
            })
          .ToList();
    }

    public List<BicyclePriceStats> GetBicycleSalesPerPriceRange()
    {
      return Context.OrderDetail
      .Include(item => item.Order)
      .Include(item => item.Product)
      .Where(item => item.Order.TimeProcessed.HasValue && item.Discriminator == ProductDiscriminator.Bicycle)
      .GroupBy(item => new
      {
        Range = item.UnitPrice <= 500 ? BicyclePriceStatsRange.TO_500 :
           item.UnitPrice <= 1000 ? BicyclePriceStatsRange.FROM_500_TO_1000 :
           item.UnitPrice <= 1500 ? BicyclePriceStatsRange.FROM_1000_TO_1500 :
           item.UnitPrice <= 2500 ? BicyclePriceStatsRange.FROM_1500_TO_2500 :
           item.UnitPrice <= 5000 ? BicyclePriceStatsRange.FROM_2500_TO_5000 :
                            BicyclePriceStatsRange.FROM_5000 // Determine the range based on product price
      })
      .Select(group => new BicyclePriceStats()
      {
        Range = group.Key.Range,
        Value = group.Sum(detail => detail.Quantity)
      })
      .OrderBy(item => item.Range) // Optional: Sort by range if needed
      .ToList();
    }


    private BicyclePriceStatsRange GetRange(decimal price)
    {
      if (price <= 500)
        return BicyclePriceStatsRange.TO_500;
      else if (price <= 1000)
        return BicyclePriceStatsRange.FROM_500_TO_1000;
      else if (price <= 1500)
        return BicyclePriceStatsRange.FROM_1000_TO_1500;
      else if (price <= 2500)
        return BicyclePriceStatsRange.FROM_1500_TO_2500;
      else if (price <= 5000)
        return BicyclePriceStatsRange.FROM_2500_TO_5000;
      else
        return BicyclePriceStatsRange.FROM_5000;
    }

  }
}