using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class BicycleSize
    {
        public BicycleSize()
        {
            AvailableSizes = new HashSet<AvailableSize>();
            OrderDetails = new HashSet<OrderDetailBicycle>();
        }

        public int BicycleSizeId { get; set; }
        public string? Size { get; set; }

        public virtual ICollection<AvailableSize> AvailableSizes { get; set; }
        public virtual ICollection<OrderDetailBicycle> OrderDetails { get; set; }
    }
}
