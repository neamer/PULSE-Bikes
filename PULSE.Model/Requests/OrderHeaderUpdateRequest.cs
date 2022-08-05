using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class OrderHeaderUpdateRequest
    {
        public string? OrderNumber { get; set; }
        public bool OnlineOrder { get; set; }
        public bool Delivery { get; set; }
        public decimal ShippingConst { get; set; }
    }
}
