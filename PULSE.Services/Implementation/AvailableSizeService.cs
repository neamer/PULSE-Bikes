using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Services.Implementation
{
    public class AvailableSizeService : BaseCRUDService<Model.AvailableSize, Data.AvailableSize, AvailableSizeSearchObject, AvailableSizeInsertRequest, AvailableSizeUpdateRequest>, IAvailableSizeService
    {
        public AvailableSizeService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<AvailableSize> AddFilter(IQueryable<AvailableSize> query, AvailableSizeSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.ProductId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.ProductId == search.ProductId);
            }

            return filteredQuery;
        }

        public override IQueryable<AvailableSize> AddInclude(IQueryable<AvailableSize> query, AvailableSizeSearchObject search = null)
        {
            query = query.Include(x => x.BicycleSize);

            return query;
        }
    }
}
