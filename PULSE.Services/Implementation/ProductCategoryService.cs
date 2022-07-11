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
    public class ProductCategoryService<T, TDb> : BaseCRUDService<T, TDb, ProductCategorySearchObject, ProductCategoryUpsertRequest, ProductCategoryUpsertRequest>, IProductCategoryService<T, TDb> where T:class where TDb : class
    {
        public ProductCategoryService(PULSEdbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
