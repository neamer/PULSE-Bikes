using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PULSE.Helpers;
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
            : base(service) { }

        [Authorize]
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

        [Authorize]
        [HttpGet("me")]
        public ActionResult me()
        {
            try
            {
                return Ok(Service.GetById(AuthHelper.GetUserId(HttpContext.User)));
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

        [Authorize]
        [HttpPut("Account")]
        public ActionResult UpdateAccount([FromBody] CustomerUpdateRequest request)
        {
            try
            {
                return Ok(((ICustomerService)Service).Update(AuthHelper.GetUserId(HttpContext.User), request));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
