using AutoMapper;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Services.Implementation
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate>
        : BaseService<T, TDb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate>
            where T : class where TDb : BaseEntity where TSearch : BaseSearchObject where TInsert : class where TUpdate : class
    {
        public BaseCRUDService(PULSEContext context, IMapper mapper)
        : base(context, mapper) { }

        public virtual T Insert(TInsert insert)
        {
            var set = Context.Set<TDb>();

            TDb entity = Mapper.Map<TDb>(insert);

            BeforeInsert(insert, entity);

            set.Add(entity);

            BeforeSave(insert, entity);

            Context.SaveChanges();

            return Mapper.Map<T>(entity);
        }

        public virtual void BeforeInsert(TInsert insert, TDb entity)
        {

        }

        public virtual void BeforeSave(TInsert insert, TDb entity)
        {

        }

        public virtual T Update(int id, TUpdate update)
        {
            var set = Context.Set<TDb>();

            var entity = set.Find(id);

            if (entity != null)
            {
                Mapper.Map(update, entity);
            }
            else
            {
                return null;
            }

            Context.SaveChanges();

            return Mapper.Map<T>(entity);
        }
    }
}
