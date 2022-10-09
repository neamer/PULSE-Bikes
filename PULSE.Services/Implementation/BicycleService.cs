﻿using AutoMapper;
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
    public class BicycleService : BaseCRUDService<Model.Bicycle, Database.Bicycle, BicycleSearchObject, BicycleUpsertRequest, BicycleUpsertRequest>, IBicycleService
    {
        public BicycleService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override IQueryable<Bicycle> AddInclude(IQueryable<Bicycle> query, BicycleSearchObject search = null)
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

        public override void BeforeInsert(BicycleUpsertRequest insert, Bicycle entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;

            base.BeforeInsert(insert, entity);
        }

        public override IQueryable<Bicycle> AddFilter(IQueryable<Bicycle> query, BicycleSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.AnyField))
            {
                filteredQuery = filteredQuery.Where(x => x.Model.Contains(search.AnyField)
                    || x.Description.Contains(search.AnyField)
                    || x.Weight.ToString().Contains(search.AnyField)
                    || x.WheelSize.Contains(search.AnyField)
                    || x.ProductionYear.ToString().Contains(search.AnyField)
                    || x.ProductNumber.Contains(search.AnyField));
            }

            if (search?.BrandId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.BrandId == search.BrandId);
            }

            if (search?.ProductCategoryId != null)
            {
                filteredQuery = filteredQuery.Where(x => x.ProductCategoryId == search.ProductCategoryId);
            }

            return filteredQuery;
        }

        public IEnumerable<Model.AvailableSize> GetAvailableSizes(int bicycleID)
        {
            var list = Context.AvailableSizes.Include(q => q.BicycleSize).Where(q => q.ProductId == bicycleID);

            return Mapper.Map<IList<Model.AvailableSize>>(list);
        }
    }
}
