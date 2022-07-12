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

        //[Authorize("Administrator")]
        public override Part Insert([FromBody] PartUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        //[Authorize("Administrator")]
        public override Part Update(int id, [FromBody] PartUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
