using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PULSE.Helpers;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;
using System.Collections.Generic;

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

        [Authorize(Roles = "Administrator,Salesperson")]
        public override ActionResult<OrderHeader> Insert([FromBody] OrderHeaderInsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        public override ActionResult<OrderHeader> Update(int id, [FromBody] OrderHeaderUpdateRequest update)
        {
            return base.Update(id, update);
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        [HttpPost("Process/{id}")]
        public virtual ActionResult<HttpStatusMessage> Process(int id, [FromBody] PaymentInsertRequest payment)
        {
            try
            {
                if( ((IOrderService)this.Service).Process(id, payment))
                {
                    return Ok(new HttpStatusMessage() { Success = true});
                }
                else
                {
                    return BadRequest(new HttpStatusMessage() { Success = false });
                }
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("Cart")]
        public virtual ActionResult<OrderHeader> Cart()
        {
            try
            {
                return Ok(((IOrderService)this.Service).Cart(AuthHelper.GetUserId(HttpContext.User)));
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        public override ActionResult<OrderHeader> GetById(int id, [FromBody] OrderSearchObject? search = null)
        {
            return Ok(((IOrderService)Service).GetDetails(id));
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        [HttpPut("Detail/{id}")]
        public virtual ActionResult<Model.OrderDetail> UpdateDetail(int id, [FromBody] OrderDetailsUpdateRequest req)
        {
            try
            {
                return Ok(((IOrderService)this.Service).UpdateDetail(id, req));
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        [HttpDelete("Detail/{id}")]
        public virtual ActionResult<Model.OrderDetail> DeleteDetail(int id)
        {
            try
            {
                return ((IOrderService)this.Service).DeleteDetail(id);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        [HttpDelete("ShippingInfo/{id}")]
        public virtual ActionResult<HttpStatusMessage> DeleteShippingInfo(int id)
        {
            try
            {
                return new HttpStatusMessage() { Success = ((IOrderService)this.Service).DeleteShippingDetails(id) };
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        //[Authorize(Roles = "Administrator,Salesperson")]
        //[HttpDelete("{id}")]
        //public virtual ActionResult<Model.OrderHeader> Delete(int id)
        //{
        //    try
        //    {
        //        return ((IOrderService)this.Service).Delete(id);
        //    }
        //    catch (InvalidOperationException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //}

        [Authorize(Roles = "Administrator,Salesperson")]
        [HttpDelete("Cancel/{id}")]
        public virtual ActionResult<Model.OrderHeader> Cancel(int id)
        {
            try
            {
                return ((IOrderService)this.Service).Cancel(id);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        [HttpPost("Pack/{id}")]
        public virtual ActionResult<Model.OrderHeader> Pack(int id)
        {
            try
            {
                return ((IOrderService)this.Service).Pack(id);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        [HttpPost("Ship/{id}")]
        public virtual ActionResult<Model.OrderHeader> Ship(int id)
        {
            try
            {
                return ((IOrderService)this.Service).Ship(id);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Salesperson")]
        [HttpPost("Deliver/{id}")]
        public virtual ActionResult<Model.OrderHeader> Deliver(int id)
        {
            try
            {
                return ((IOrderService)this.Service).Deliver(id);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
