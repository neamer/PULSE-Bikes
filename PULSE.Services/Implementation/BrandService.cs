using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Services.Implementation
{
    public class BrandService : BaseCRUDService<Model.Brand, Data.Brand, NameGenericSearchObject, BrandUpsertRequest, BrandUpsertRequest>, IBrandService
    {
        public BrandService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Brand> AddFilter(IQueryable<Brand> query, NameGenericSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!String.IsNullOrEmpty(search.Name))
            {
                filteredQuery = filteredQuery.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));
            }

            return filteredQuery;
        }
    }
}
