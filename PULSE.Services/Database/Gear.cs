using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class Gear
    {
        public int ProductId { get; set; }
        public int? GearCategoryId { get; set; }
        public int? AvailableQty { get; set; }

        public virtual GearCategory? GearCategory { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}
