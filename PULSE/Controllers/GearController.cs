using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GearController : BaseCRUDController<Gear, GearSearchObject, GearUpsertRequest, GearUpsertRequest>
    {
        public GearController(IGearService service)
            : base(service)
        {
        }

        //[Authorize("Administrator")]
        public override Gear Insert([FromBody] GearUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        //[Authorize("Administrator")]
        public override Gear Update(int id, [FromBody] GearUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
