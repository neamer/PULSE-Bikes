using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Implementation;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BicycleController : BaseCRUDController<Bicycle, BicycleSearchObject, BicycleUpsertRequest, BicycleUpsertRequest>
    {
        public BicycleController(IBicycleService service)
            : base(service)
        {
        }

        [HttpGet("Sizes/{id}")]
        public ActionResult<IEnumerable<AvailableSize>> GetAvailableSizes(int id)
        {
            return Ok(((BicycleService)Service).GetAvailableSizes(id));
        }

        [Authorize(Roles = "Administrator,Storekeeper")]
        public override ActionResult<Bicycle> Insert([FromBody] BicycleUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Administrator,Storekeeper")]
        public override ActionResult<Bicycle> Update(int id, [FromBody] BicycleUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
