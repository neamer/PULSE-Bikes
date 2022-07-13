using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
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

        //[Authorize("Administrator")]
        public override Bicycle Insert([FromBody] BicycleUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        //[Authorize("Administrator")]
        public override Bicycle Update(int id, [FromBody] BicycleUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
