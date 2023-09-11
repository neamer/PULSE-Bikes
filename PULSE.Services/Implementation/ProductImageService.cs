using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Services.Implementation
{
    public class ProductImageService : BaseCRUDService<Model.ProductImage, Data.ProductImage, ProductImageSearchObject, ProductImageUpsertRequest, ProductImageUpsertRequest>, IProductImageService
    {
        public ProductImageService(PULSEContext context, IMapper mapper) 
            : base(context, mapper) {}


        public override IQueryable<ProductImage> AddFilter(IQueryable<ProductImage> query, ProductImageSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);


            if (search?.ProductId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.ProductId == search.ProductId);
            }

            return filteredQuery;
        }
    }
}
