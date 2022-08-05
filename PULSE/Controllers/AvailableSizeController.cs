using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AvailableSizeController : BaseCRUDController<AvailableSize, AvailableSizeSearchObject, AvailableSizeUpsertRequest, AvailableSizeUpsertRequest>
    {
        public AvailableSizeController(IAvailableSizeService service)
            : base(service)
        {
        }

        //[Authorize("Administrator")]
        public override AvailableSize Insert([FromBody] AvailableSizeUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        //[Authorize("Administrator")]
        [HttpPut]
        public override AvailableSize Update(int id, [FromBody] AvailableSizeUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
