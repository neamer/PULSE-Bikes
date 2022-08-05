using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BicycleSizeController : BaseCRUDController<BicycleSize, NameGenericSearchObject, BicycleSizeUpsertRequest, BicycleSizeUpsertRequest>
    {
        public BicycleSizeController(IBicycleSizeService service)
            : base(service)
        {
        }

        //[Authorize("Administrator")]
        public override BicycleSize Insert([FromBody] BicycleSizeUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        //[Authorize("Administrator")]
        public override BicycleSize Update(int id, [FromBody] BicycleSizeUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
