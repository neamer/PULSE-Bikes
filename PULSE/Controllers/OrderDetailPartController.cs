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
    public class OrderDetailPartController : BaseCRUDController<OrderDetail, BaseSearchObject, OrderDetailsInsertRequest, OrderDetailsUpdateRequest>
    {
        public OrderDetailPartController(IOrderDetailPartService service)
            : base(service)
        {
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        public override ActionResult<OrderDetail> Insert([FromBody] OrderDetailsInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        public override ActionResult<OrderDetail> Update(int id, [FromBody] OrderDetailsUpdateRequest update)
        {
            return base.Update(id, update);
        }

        [ExcludeFromDescription]
        public override ActionResult<IEnumerable<OrderDetail>> Get([FromQuery] BaseSearchObject search = null)
        {
            return new List<OrderDetail>();
        }

        [HttpPost("Cart")]
        public ActionResult<OrderDetail> AddToCart([FromBody] OrderDetailsInsertRequest insert)
        {
            try
            {
                return Ok(((IOrderDetailPartService)Service)
                    .AddToCart(AuthHelper.GetUserId(HttpContext.User), insert));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
