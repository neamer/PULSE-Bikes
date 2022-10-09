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
    public class CustomerService : BaseCRUDService<Model.Customer, Database.Customer, NameGenericSearchObject, CustomerInsertRequest, CustomerUpdateRequest>, ICustomerService
    {
        public CustomerService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Customer> AddFilter(IQueryable<Customer> query, NameGenericSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                filteredQuery = filteredQuery.Where(x => x.Username.ToLower().Contains(search.Name.ToLower())
                    || x.FirstName.ToLower().Contains(search.Name.ToLower())
                    || (x.FirstName.ToLower() + " " + x.LastName.ToLower()).Contains(search.Name.ToLower())
                    || x.LastName.ToLower().Contains(search.Name.ToLower()));
            }

            return filteredQuery;
        }
    }
}
