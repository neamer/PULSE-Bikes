
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

    [HttpGet("sales-per-month")]
    public virtual ActionResult<List<Stats>> Get()
    {
      try
      {
        return Ok(Service.GetSalesPerMonth());
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
  }
}
