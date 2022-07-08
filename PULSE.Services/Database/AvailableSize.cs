using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class AvailableSize
    {
        public int BicycleSizeId { get; set; }
        public int BicycleId { get; set; }
        public int? AvailableQty { get; set; }

        public virtual Bicycle Bicycle { get; set; } = null!;
        public virtual BicycleSize BicycleSize { get; set; } = null!;
    }
}
