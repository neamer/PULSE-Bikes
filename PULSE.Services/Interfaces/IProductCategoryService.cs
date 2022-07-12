using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Interfaces
{
    public interface IProductCategoryService<T, TDb> : ICRUDService<T, NameGenericSearchObject, ProductCategoryUpsertRequest, ProductCategoryUpsertRequest> where T : class
    {
    }
}
