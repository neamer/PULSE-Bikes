using System.Globalization;
using PULSE.Model;

namespace PULSE.Services.Interfaces
{
  public interface IStatsService
  {
    public List<Stats> GetSalesPerMonth();
  }
}