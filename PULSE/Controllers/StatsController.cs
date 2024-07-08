
using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class StatsController : ControllerBase
  {
    public IStatsService Service { get; set; }

    public StatsController(IStatsService service)
    {
      Service = service;
    }

    [HttpGet("revenue-per-month/{year}")]
    public virtual ActionResult<List<MonthlyStats>> RevenuePerMonth(int year)
    {
      try
      {
        return Ok(Service.GetRevenuePerMonth(year));
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    [HttpGet("sales-per-month/{year}")]
    public virtual ActionResult<List<MonthlyStats>> GetSalesPerMonth(int year)
    {
      try
      {
        return Ok(Service.GetSalesPerMonth(year));
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    [HttpGet("bicycle-sales-per-category")]
    public virtual ActionResult<List<BicycleCategoryStats>> GetBicycleCategoryStats()
    {
      try
      {
        return Ok(Service.GetBicycleSalesPerType());
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    [HttpGet("bicycle-sales-per-price-range")]
    public virtual ActionResult<List<BicyclePriceStats>> GetBicycleSalesPerPriceRange()
    {
      try
      {
        return Ok(Service.GetBicycleSalesPerPriceRange());
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
  }
}
