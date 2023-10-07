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

        [HttpPost("public")]
        public ActionResult<OrderDetail> PublicInsert([FromBody] OrderDetailBicycleInsertRequest insert)
        {
            try
            {
                var userId = HttpContext.Session.GetString("AuthenticatedUser");


                return Ok(((IOrderDetailBicycleService)Service).Insert(insert));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
