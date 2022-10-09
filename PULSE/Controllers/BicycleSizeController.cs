using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "Administrator,Storekeeper")]
        public override ActionResult<BicycleSize> Insert([FromBody] BicycleSizeUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Administrator,Storekeeper")]
        public override ActionResult<BicycleSize> Update(int id, [FromBody] BicycleSizeUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
