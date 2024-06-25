
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


    public List<Stats> GetSalesPerMonth()
    {
      return Context.OrderDetail
          .Include(item => item.Order)
          .Where(item => item.Order.TimeProcessed.HasValue)
          .GroupBy(item => new { item.Order.TimeProcessed.Value.Year, item.Order.TimeProcessed.Value.Month })
            .Select(group => new Stats
            {
              Year = group.Key.Year,
              Month = group.Key.Month,
              Value = group.Sum(detail => detail.Quantity * detail.UnitPrice) // Example calculation, adjust as per your requirement
            })
          .OrderBy(result => result.Year)
          .ThenBy(result => result.Month)
          .ToList();
    }
  }
}