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
    public class AvailableSizeController : BaseCRUDController<AvailableSize, AvailableSizeSearchObject, AvailableSizeUpsertRequest, AvailableSizeUpsertRequest>
    {
        public AvailableSizeController(IAvailableSizeService service)
            : base(service)
        {
        }

        [Authorize(Roles = "Administrator,Storekeeper")]
        public override ActionResult<AvailableSize> Insert([FromBody] AvailableSizeUpsertRequest insert)
        {
            try
            {
                return base.Insert(insert);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Storekeeper")]
        [HttpPut]
        public override ActionResult<AvailableSize> Update(int id, [FromBody] AvailableSizeUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
