using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffController : BaseCRUDController<Model.Staff, StaffSearchObject, StaffInsertRequest, StaffUpdateRequest>
    {
        public StaffController(IStaffService service)
            : base(service)
        {
        }

        //[Authorize("Administrator")]
        public override Staff Insert([FromBody] StaffInsertRequest insert)
        {
            return base.Insert(insert);
        }

        //[Authorize("Administrator")]
        public override Staff Update(int id, [FromBody] StaffUpdateRequest update)
        {
            return base.Update(id, update);
        }

    }
}
