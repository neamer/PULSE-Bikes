using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using OrderDetail = PULSE.Model.OrderDetail;
using OrderHeader = PULSE.Model.OrderHeader;

namespace PULSE.Services.Interfaces
{
    public interface IOrderService : ICRUDService<OrderHeader, OrderSearchObject, OrderHeaderInsertRequest, OrderHeaderUpdateRequest>
    {
        public OrderHeader Process(int id, PaymentInsertRequest req);
        public OrderHeader GetDetails(int id);
        public OrderHeader GetDetailsForCustomer(int id);
        public OrderDetail UpdateDetail(int id, OrderDetailsUpdateRequest req);
        public OrderDetail DeleteDetail(int id);
        public OrderHeader Delete(int id);
        public bool DeleteShippingDetails(int id);
        public OrderHeader Cancel(int id);
        public OrderHeader Pack(int id);
        public OrderHeader Ship(int id);
        public OrderHeader Deliver(int id);
        public Data.OrderHeader GetDraftOrderForCustomer(int customerId);
        public OrderHeader Cart(int customerId);
        public OrderHeader ProcessCustomer(int customerId, OrderRequest request);
        public OrderDetail RemoveCartItem(int customerId, int itemId);

    }
}
