using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;
using PULSE.Services.Utils;
using System.Security.Cryptography;
using System.Text;

namespace PULSE.Services.Implementation
{
    public class StaffService : BaseCRUDService<Model.Staff, Data.staff, StaffSearchObject, StaffInsertRequest, StaffUpdateRequest>, IStaffService
    {
        public StaffService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override Model.Staff Insert(StaffInsertRequest insert)
        {
            if(Context.staff.Where(x => x.Username.Equals(insert.Username)).Count() > 0)
            {
                throw new Exception("Username already taken");
            }

            if (insert.Password != insert.PasswordConfirm)
            {
                throw new Exception("Password and confirmation must be the same");
            }

            var entity = base.Insert(insert);

            Context.SaveChanges();

            return entity;
        }


        public override void BeforeSave(StaffInsertRequest insert, Data.staff entity)
        {
            var salt = AuthUtils.GenerateSalt();
            entity.PasswordSalt = salt;
            entity.PasswordHash = AuthUtils.GenerateHash(salt, insert.Password);

            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;

            entity.Status = true;

            base.BeforeSave(insert, entity);
        }


        public override IQueryable<Data.staff> AddFilter(IQueryable<Data.staff> query, StaffSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.AnyField))
            {
                filteredQuery = filteredQuery.Where(x => x.FirstName.ToLower().Contains(search.AnyField.ToLower())
                    || x.LastName.ToLower().Contains(search.AnyField.ToLower())
                    || x.Username.ToLower().Contains(search.AnyField.ToLower())
                    || x.Email.ToLower().Contains(search.AnyField.ToLower())
                    || x.PhoneNumber.ToLower().Contains(search.AnyField.ToLower()));
            }

            if (search?.RoleId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.RoleId == search.RoleId);
            }

            if (search?.Status != null)
            {
                filteredQuery = filteredQuery.Where(x => x.Status == search.Status);
            }

            return filteredQuery;
        }

        public override IQueryable<Data.staff> AddInclude(IQueryable<Data.staff> query, StaffSearchObject search = null)
        {
            if (search?.IncludeRole == true)
            {
                query = query.Include(s => s.Role);
            }
            return query;
        }

        public Model.Staff Login(LoginRequest request)
        {
            var entity = Context.staff.Include(s => s.Role).FirstOrDefault(x => x.Username == request.Username);
            if (entity == null)
            {
                throw new Exception("User not found");
            }

            var hash = AuthUtils.GenerateHash(entity.PasswordSalt, request.Password);

            if (hash != entity.PasswordHash)
            {
                throw new Exception("Wrong Password");
            }

            return Mapper.Map<Model.Staff>(entity);
        }

        public IEnumerable<Model.Role> GetRoles()
        {
            var list = Context.Roles.ToList();
            return Mapper.Map<IList<Model.Role>>(list);
        }

        public Model.Staff Delete(int id)
        {
            var entity = Context.staff.Find(id);

            if(entity == null)
            {
                throw new KeyNotFoundException("Staff member not found!");
            }

            Context.staff.Remove(entity);
            Context.SaveChanges();

            return Mapper.Map<Model.Staff>(entity);
        }
    }
}
