using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;

namespace PULSE.Services.Interfaces
{
    public interface IProductCategoryService<T, TDb> : ICRUDService<T, NameGenericSearchObject, ProductCategoryUpsertRequest, ProductCategoryUpsertRequest> where T : class
    {
    }
}
