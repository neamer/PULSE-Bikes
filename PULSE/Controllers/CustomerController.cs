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
    public class CustomerController : BaseCRUDController<Customer, NameGenericSearchObject, CustomerInsertRequest, CustomerUpdateRequest>
    {
        public CustomerController(ICustomerService service)
            : base(service) {}

        [HttpPost("login")]
        public ActionResult Login()
        {
            try
            {
                return Ok("AUTHENTICATED");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        public override ActionResult<Customer> Insert([FromBody] CustomerInsertRequest insert)
        {
            return base.Insert(insert);
        }

    }
}
