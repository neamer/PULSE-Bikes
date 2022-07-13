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
    public class BicycleCategoryController : BaseCRUDController<Model.ProductCategory, NameGenericSearchObject, ProductCategoryUpsertRequest, ProductCategoryUpsertRequest>
    {
        public BicycleCategoryController(IProductCategoryService<Model.ProductCategory, BicycleCategory> service)
            : base(service)
        {
        }

        //[Authorize("Administrator")]
        public override Model.ProductCategory Insert([FromBody] ProductCategoryUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        //[Authorize("Administrator")]
        public override Model.ProductCategory Update(int id, [FromBody] ProductCategoryUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
