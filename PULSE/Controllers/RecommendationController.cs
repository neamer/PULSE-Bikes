using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class RecommendationController : ControllerBase
  {
    public IRecommendationService Service { get; set; }

    public RecommendationController(IRecommendationService service)
    {
      Service = service;
    }

    [HttpGet("similar-products/{id}")]
    public virtual ActionResult<List<ProductAIO>> GetSimilarProducts(int id)
    {
      try
      {
        return Ok(Service.GetSimilarProducts(id));
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }
  }
}
