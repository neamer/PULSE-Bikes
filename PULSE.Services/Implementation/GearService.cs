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
        public GearService(PULSEdbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override void BeforeInsert(GearUpsertRequest insert, Gear entity)
        {
            var product = Mapper.Map<Product>(insert);
            product.Discriminator = Model.ProductDiscriminator.Gear;
            Context.Products.Add(product);
            Context.SaveChanges();

            entity.ProductId = product.ProductId;

            base.BeforeInsert(insert, entity);
        }

        public override IQueryable<Gear> AddInclude(IQueryable<Gear> query, GearSearchObject search = null)
        {
            query = query.Include(entity => entity.Product);

            return query;
        }
    }
}
