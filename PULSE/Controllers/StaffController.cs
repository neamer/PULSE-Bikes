using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [Authorize(Roles = "Administrator")]
    [ApiController]
    [Route("[controller]")]
    public class StaffController : BaseCRUDController<Model.Staff, StaffSearchObject, StaffInsertRequest, StaffUpdateRequest>
    {
        public StaffController(IStaffService service)
            : base(service)
        {
        }

        public override Staff Insert([FromBody] StaffInsertRequest insert)
        {
            return base.Insert(insert);
        }

        public override Staff Update(int id, [FromBody] StaffUpdateRequest update)
        {
            return base.Update(id, update);
        }

        public override IEnumerable<Staff> Get([FromQuery] StaffSearchObject search = null)
        {
            return base.Get(search);
        }

        public override Staff GetById(int id)
        {
            return base.GetById(id);
        }
    }
}
