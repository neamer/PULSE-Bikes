using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Services.Implementation
{
    public class ProductCategoryService<T, TDb> : BaseCRUDService<T, TDb, NameGenericSearchObject, ProductCategoryUpsertRequest, ProductCategoryUpsertRequest>, IProductCategoryService<T, TDb> where T:class where TDb : ProductCategory
    {
        public ProductCategoryService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<TDb> AddFilter(IQueryable<TDb> query, NameGenericSearchObject search = null)
        {
            var filteredQuery =  base.AddFilter(query, search);

            if(!String.IsNullOrEmpty(search.Name))
            {
                filteredQuery = filteredQuery.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            return filteredQuery;
        }
    }
}
