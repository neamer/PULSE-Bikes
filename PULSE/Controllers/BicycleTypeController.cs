using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Database;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BicycleTypeController : BaseCRUDController<ProductCategory, NameGenericSearchObject, ProductCategoryUpsertRequest, ProductCategoryUpsertRequest>
    {
        public BicycleTypeController(IProductCategoryService<ProductCategory, BicycleType> service)
            : base(service)
        {
        }

        //[Authorize("Administrator")]
        public override ProductCategory Insert([FromBody] ProductCategoryUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        //[Authorize("Administrator")]
        public override ProductCategory Update(int id, [FromBody] ProductCategoryUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
