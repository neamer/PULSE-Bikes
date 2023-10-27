using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Interfaces
{
    public interface IOrderService : ICRUDService<OrderHeader, OrderSearchObject, OrderHeaderInsertRequest, OrderHeaderUpdateRequest>
    {
        public bool Process(int id, PaymentInsertRequest req);
        public OrderHeader GetDetails(int id);
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

    }
}
