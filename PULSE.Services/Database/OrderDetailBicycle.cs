using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Database
{
    public class OrderDetailBicycle : OrderDetail
    {
        public int? BicycleSizeId { get; set; }

        public virtual BicycleSize? BicycleSize { get; set; }
    }
}
