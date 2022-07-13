using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class AvailableSize
    {
        public int BicycleSizeId { get; set; }
        public int ProductId { get; set; }
        public int? AvailableQty { get; set; }

        public virtual BicycleSize BicycleSize { get; set; } = null!;
        public virtual Bicycle Product { get; set; } = null!;
    }
}
