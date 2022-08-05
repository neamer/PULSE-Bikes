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
        public abstract Model.OrderHeader Process(PaymentInsertRequest req);
    }
}
