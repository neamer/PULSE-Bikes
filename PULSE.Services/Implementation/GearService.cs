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
    public class GearService : BaseCRUDService<Model.Gear, Database.Gear, GearSearchObject, GearUpsertRequest, GearUpsertRequest>, IGearService
    {
        public GearService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Gear> AddInclude(IQueryable<Gear> query, GearSearchObject search = null)
        {
            if (search?.IncludeBrand == true)
            {
                query = query.Include(q => q.Brand);
            }

            if (search?.IncludeCategory == true)
            {
                query = query.Include(q => q.ProductCategory);
            }

            return query;
        }

        public override void BeforeInsert(GearUpsertRequest insert, Gear entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;

            base.BeforeInsert(insert, entity);
        }

        public override IQueryable<Gear> AddFilter(IQueryable<Gear> query, GearSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.AnyField))
            {
                filteredQuery = filteredQuery.Where(x => x.Model.Contains(search.AnyField)
                    || x.Description.Contains(search.AnyField)
                    || x.AvailableQty.ToString().Contains(search.AnyField)
                    || x.Price.ToString().Contains(search.AnyField)
                    || x.ProductNumber.Contains(search.AnyField));
            }

            if (search?.BrandId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.BrandId == search.BrandId);
            }

            if (search?.ProductCategoryId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.ProductCategoryId == search.ProductCategoryId);
            }

            return filteredQuery;
        }
    }
}
