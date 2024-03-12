using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Services.Implementation
{
    public class BicycleSizeService : BaseCRUDService<Model.BicycleSize, Data.BicycleSize, NameGenericSearchObject, BicycleSizeUpsertRequest, BicycleSizeUpsertRequest>, IBicycleSizeService
    {
        public BicycleSizeService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<BicycleSize> AddFilter(IQueryable<BicycleSize> query, NameGenericSearchObject? search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!String.IsNullOrEmpty(search.Name))
            {
                filteredQuery = filteredQuery.Where(x => x.Size.ToLower().Contains(search.Name.ToLower()));
            }

            return filteredQuery;
        }
    }
}
