using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Services.Implementation
{
    public class ProductImageService : BaseCRUDService<Model.ProductImage, Data.ProductImage, BaseSearchObject, ProductImageUpsertRequest, ProductImageUpsertRequest>, IProductImageService
    {
        public ProductImageService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
