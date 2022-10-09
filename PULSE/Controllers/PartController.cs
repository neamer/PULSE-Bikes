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
    public class PartController : BaseCRUDController<Part, PartSearchObject, PartUpsertRequest, PartUpsertRequest>
    {
        public PartController(IPartService service)
            : base(service)
        {
        }

        [Authorize(Roles = "Administrator,Storekeeper,Mechanic")]
        public override ActionResult<Part> Insert([FromBody] PartUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Administrator,Storekeeper,Mechanic")]
        public override ActionResult<Part> Update(int id, [FromBody] PartUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
