using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : BaseCRUDController<Customer, NameGenericSearchObject, CustomerInsertRequest, CustomerUpdateRequest>
    {
        public CustomerController(ICustomerService service)
            : base(service) {}

        [HttpPost("login")]
        public ActionResult<Staff> Login([FromBody] LoginRequest req)
        {
            try
            {
                return Ok((Service as IStaffService).Login(req));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
