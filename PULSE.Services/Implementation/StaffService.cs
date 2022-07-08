using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Database;
using PULSE.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Implementation
{
    public class StaffService : BaseCRUDService<Model.Staff, Database.staff, StaffSearchObject, StaffInsertRequest, StaffUpdateRequest>, IStaffService
    {
        public StaffService(PULSEdbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override Model.Staff Insert(StaffInsertRequest insert)
        {

            if (insert.Password != insert.PasswordConfirm)
            {
                throw new Exception("Password and confirmation must be the same");
            }

            var entity = base.Insert(insert);


            foreach (var roleID in insert.RoleIDList)
            {
                var dbEntity = Context.staff.Find(entity.StaffId);

                dbEntity.Roles.Add(Context.Roles.Find(roleID));
                dbEntity.UpdatedAt = DateTime.Now;
            }

            Context.SaveChanges();

            return entity;
        }

        public override void BeforeInsert(StaffInsertRequest insert, Database.staff entity)
        {
            var salt = GenerateSalt();
            entity.PasswordSalt = salt;
            entity.PasswordHash = GenerateHash(salt, insert.Password);
            base.BeforeInsert(insert, entity);
        }


        public static string GenerateSalt()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);


            return Convert.ToBase64String(byteArray);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public override IQueryable<Database.staff> AddFilter(IQueryable<Database.staff> query, StaffSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                filteredQuery = filteredQuery.Where(x => x.Username == search.Username);
            }

            if (!string.IsNullOrWhiteSpace(search?.NameFTS))
            {
                filteredQuery = filteredQuery.Where(x => x.Username.Contains(search.NameFTS)
                    || x.FirstName.Contains(search.NameFTS)
                    || x.LastName.Contains(search.NameFTS));
            }

            return filteredQuery;
        }

        public override IQueryable<Database.staff> AddInclude(IQueryable<Database.staff> query, StaffSearchObject search = null)
        {
            if (search?.IncludeRoles == true)
            {
                query = query.Include(s => s.Roles);
            }
            return query;
        }

        public Model.Staff Login(string username, string password)
        {
            var entity = Context.staff.Include("StaffUloges.Uloga").FirstOrDefault(x => x.Username == username);
            if (entity == null)
            {
                return null;
            }

            var hash = GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
            {
                return null;
            }

            return Mapper.Map<Model.Staff>(entity);
        }
    }
}
