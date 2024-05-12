using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class OrderHeaderInsertRequest
    {
        public OrderHeaderInsertRequest()
        {
            OrderDetails = new HashSet<OrderDetailsAIOInsertRequest>();
        }
        
        public string? OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public bool OnlineOrder { get; set; }
        public bool Delivery { get; set; }
        public decimal? ShippingConst { get; set; }

        public virtual ShippingInfoUpsertRequest? ShippingInfo { get; set; }
        public virtual ICollection<OrderDetailsAIOInsertRequest> OrderDetails { get; set; }
    }
}
