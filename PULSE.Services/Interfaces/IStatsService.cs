using System.Globalization;
using PULSE.Model;

namespace PULSE.Services.Interfaces
{
  public interface IStatsService
  {
    public List<MonthlyStats> GetRevenuePerMonth(int year);
    public List<MonthlyStats> GetSalesPerMonth(int year);
    public List<BicycleCategoryStats> GetBicycleSalesPerType();
    public List<BicyclePriceStats> GetBicycleSalesPerPriceRange();
  }
}