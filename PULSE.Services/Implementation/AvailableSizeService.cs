using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Database;
using PULSE.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Implementation
{
    public class AvailableSizeService : BaseCRUDService<Model.AvailableSize, Database.AvailableSize, AvailableSizeSearchObject, AvailableSizeUpsertRequest, AvailableSizeUpsertRequest>, IAvailableSizeService
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

        public override Model.AvailableSize Update(int id, AvailableSizeUpsertRequest update)
        {
            var set = Context.Set<Database.AvailableSize>();

            var entity = set.Where(x => x.ProductId == update.ProductId && x.BicycleSizeId == update.BicycleSizeId).First();

            if (entity != null)
            {
                Mapper.Map(update, entity);
            }
            else
            {
                return null;
            }

            Context.SaveChanges();

            return Mapper.Map<Model.AvailableSize>(entity);
        }
    }
}
