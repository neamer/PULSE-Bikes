using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class OrderDetailsAIOInsertRequest : OrderDetailBicycleInsertRequest
    {
        public string Discriminator { get; set; }
    }
}
