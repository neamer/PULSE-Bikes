using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : BaseCRUDController<OrderHeader, OrderSearchObject, OrderHeaderInsertRequest, OrderHeaderUpdateRequest>
    {
        public OrderController(IOrderService service)
            : base(service)
        {
        }

        //[Authorize("Administrator")]
        public override OrderHeader Insert([FromBody] OrderHeaderInsertRequest insert)
        {
            return base.Insert(insert);
        }

        //[Authorize("Administrator")]
        public override OrderHeader Update(int id, [FromBody] OrderHeaderUpdateRequest update)
        {
            return base.Update(id, update);
        }

    }
}
