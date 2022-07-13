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
    }
}
