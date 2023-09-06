using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    //[Authorize(Roles = "Administrator")]
    [ApiController]
    [Route("[controller]")]
    public class StaffController : BaseCRUDController<Model.Staff, StaffSearchObject, StaffInsertRequest, StaffUpdateRequest>
    {
        public StaffController(IStaffService service)
            : base(service)
        {
        }

        [Authorize(Roles = "Administrator")]
        public override ActionResult<Staff> Insert([FromBody] StaffInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Administrator")]
        public override ActionResult<Staff> Update(int id, [FromBody] StaffUpdateRequest update)
        {
            return base.Update(id, update);
        }

        [Authorize(Roles = "Administrator")]
        public override ActionResult<IEnumerable<Staff>> Get([FromQuery] StaffSearchObject search = null)
        {
            return base.Get(search);
        }

        [Authorize(Roles = "Administrator")]
        public override ActionResult<Staff> GetById(int id, [FromBody] StaffSearchObject? search = null)
        {
            return base.GetById(id);
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("roles")]
        public ActionResult<IEnumerable<Role>> GetRoles()
        {
            try
            {
                return Ok((Service as IStaffService).GetRoles());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public ActionResult<Staff> Delete(int id)
        {
            try
            {
                return Ok((Service as IStaffService).Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public ActionResult<Staff> Login([FromBody] LoginRequest req)
        {
            try
            {
                return Ok((Service as IStaffService).Login(req.Username, req.Password));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
