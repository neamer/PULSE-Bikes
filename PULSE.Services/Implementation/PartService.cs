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
    public class PartService : BaseCRUDService<Model.Part, Database.Part, PartSearchObject, PartUpsertRequest, PartUpsertRequest>, IPartService
    {
        public PartService(PULSEdbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override void BeforeInsert(PartUpsertRequest insert, Part entity)
        {
            var product = Mapper.Map<Product>(insert);
            product.Discriminator = Model.ProductDiscriminator.Part;
            Context.Products.Add(product);
            Context.SaveChanges();

            entity.ProductId = product.ProductId;

            base.BeforeInsert(insert, entity);
        }

        public override IQueryable<Part> AddInclude(IQueryable<Part> query, PartSearchObject search = null)
        {
            query = query.Include(entity => entity.Product);

            return query;
        }
    }
}
