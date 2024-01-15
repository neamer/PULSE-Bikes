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
    public class ServicingController : Controller
    {
        public IServicingService Service { get; set; }

        public ServicingController(IServicingService service)
        {
            Service = service;
        }

        [HttpGet]
        public virtual ActionResult<Servicing> Get([FromQuery] ServicingSearchObject search = null)
        {
            try
            {
                return Ok(Service.Get(search));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Mechanic")]
        [HttpPost]
        public virtual ActionResult<Servicing> Register([FromBody] RegisterServicingRequest req)
        {
            try
            {
                return Service.RegisterServicing(req);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Mechanic")]
        [HttpDelete("{id}")]
        public virtual ActionResult<Servicing> Cancel(int id)
        {
            try
            {
                return Service.Cancel(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Mechanic")]
        [HttpPut("{id}")]
        public virtual ActionResult<Servicing> Update(int id, [FromBody] ServicingUpdateRequest req)
        {
            try
            {
                return Service.Update(id, req);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Mechanic")]
        [HttpPost("{id}/Offer")]
        public virtual ActionResult<Servicing> SubmitOffer(int id, [FromBody] ServicingOfferInsertRequest req)
        {
            try
            {
                return Service.SubmitOFfer(id, req);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Mechanic")]
        [HttpPost("{id}/RegisterPayment")]
        public virtual ActionResult<Servicing> RegisterAcceptedOffer(int id, [FromBody] PaymentInsertRequest req)
        {
            try
            {
                return Service.RegisterAcceptedOffer(id, req);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public virtual ActionResult<Servicing> GetById(int id)
        {
            try
            {
                return Ok(Service.GetDetails(id));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Administrator,Mechanic")]
        [HttpPost("{id}/Complete")]
        public virtual ActionResult<Servicing> ServicingCompleted(int id)
        {
            try
            {
                return Service.Complete(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Authorize]
        [HttpGet("Customer")]
        public virtual ActionResult<IEnumerable<Servicing>> GetForCustomer([FromQuery] ServicingSearchObject? search)
        {
            try
            {
                search.CustomerId = AuthHelper.GetUserId(HttpContext.User);
                return Ok(((IServicingService)this.Service).Get(search));
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

        [HttpGet("Details/{id}")]
        public ActionResult<Servicing> Details(int id)
        {
            // TODO: Protect endpoint
            return Ok(((IServicingService)Service).GetDetailsForCustomer(id));
        }
    }
}
