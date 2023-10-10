using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;

namespace PULSE.Services.Interfaces
{
    public interface IOrderDetailGearService : ICRUDService<OrderDetail, BaseSearchObject, OrderDetailsInsertRequest, OrderDetailsUpdateRequest>
    {
        public Model.OrderDetail AddToCart(int customerId, OrderDetailsInsertRequest req);
    }
}
