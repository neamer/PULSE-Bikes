using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PULSE.Helpers;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;
using System.Security.Claims;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderDetailBicycleController : BaseCRUDController<OrderDetail, BaseSearchObject, OrderDetailBicycleInsertRequest, OrderDetailsUpdateRequest>
    {
        public OrderDetailBicycleController(IOrderDetailBicycleService service)
            : base(service) {}

        [Authorize(Roles = "Administrator,Salesperson")]
        public override ActionResult<OrderDetail> Insert([FromBody] OrderDetailBicycleInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        public override ActionResult<OrderDetail> Update(int id, [FromBody] OrderDetailsUpdateRequest update)
        {
            return base.Update(id, update);
        }

        [HttpPost("Cart")]
        public ActionResult<OrderDetail> AddToCart([FromBody] OrderDetailBicycleInsertRequest insert)
        {
            try
            {
                return Ok(((IOrderDetailBicycleService)Service)
                    .AddToCart(AuthHelper.GetUserId(HttpContext.User), insert));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
