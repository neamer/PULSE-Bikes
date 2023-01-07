﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class BaseService<T, TDb, TSearch> : IService<T, TSearch> where T : class where TDb : class where TSearch : BaseSearchObject
    {
        public PULSEContext Context { get; set; }
        public IMapper Mapper { get; set; }

        public BaseService(PULSEContext context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }
        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var set = Context.Set<TDb>().AsQueryable();

            set = AddFilter(set, search);

            set = AddInclude(set, search);

            var entity = set.AsQueryable();

            if (search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                entity = entity.Skip(search.Page.Value * search.PageSize.Value).Take(search.PageSize.Value);
            }

            var list = entity.ToList();
            return Mapper.Map<IList<T>>(list);
        }

        public virtual IQueryable<TDb> AddInclude(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }

        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }

        public T GetById(int id)
        {
            var set = Context.Set<TDb>();

            var entity = set.Find(id);

            if(entity == null)
            {
                throw new Exception("Not Found");
            }

            return Mapper.Map<T>(entity);
        }
    }
}
