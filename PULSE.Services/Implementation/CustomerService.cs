using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;
using PULSE.Services.Utils;

namespace PULSE.Services.Implementation
{
    public class CustomerService : BaseCRUDService<Model.Customer, Data.Customer, NameGenericSearchObject, CustomerInsertRequest, CustomerUpdateRequest>, ICustomerService
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

        public override void BeforeSave(CustomerInsertRequest insert, Data.Customer entity)
        {
            var salt = AuthUtils.GenerateSalt();
            entity.PasswordSalt = salt;
            entity.PasswordHash = AuthUtils.GenerateHash(salt, insert.Password);

            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;

            entity.Status = true;

            base.BeforeSave(insert, entity);
        }

        public Model.Customer Login(LoginRequest request)
        {
            var entity = Context.Customers.FirstOrDefault(x => x.Username == request.Username);
            if (entity == null)
            {
                throw new Exception("User not found");
            }

            var hash = AuthUtils.GenerateHash(entity.PasswordSalt, request.Password);

            if (hash != entity.PasswordHash)
            {
                throw new Exception("Wrong Password");
            }

            return Mapper.Map<Model.Customer>(entity);
        }
    }
}
