using AutoMapper;
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
    public class BrandService : BaseCRUDService<Model.Brand, Database.Brand, NameGenericSearchObject, BrandUpsertRequest, BrandUpsertRequest>, IBrandService
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
