using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : BaseCRUDController<Brand, NameGenericSearchObject, BrandUpsertRequest, BrandUpsertRequest>
    {
        public BrandController(IBrandService service)
            : base(service)
        {
        }

        //[Authorize("Administrator")]
        public override Brand Insert([FromBody] BrandUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        //[Authorize("Administrator")]
        public override Brand Update(int id, [FromBody] BrandUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
