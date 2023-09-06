using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductImageController : BaseCRUDController<ProductImage, BaseSearchObject, ProductImageUpsertRequest, ProductImageUpsertRequest>
    {
        public ProductImageController(IProductImageService service)
            : base(service)
        {
        }
    }
}
