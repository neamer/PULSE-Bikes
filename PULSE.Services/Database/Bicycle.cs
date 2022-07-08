using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class Bicycle
    {
        public Bicycle()
        {
            AvailableSizes = new HashSet<AvailableSize>();
        }

        public int ProductId { get; set; }
        public int? BicycleTypeId { get; set; }
        public decimal? Weight { get; set; }
        public int? ProductionYear { get; set; }
        public string? WheelSize { get; set; }

        public virtual BicycleType? BicycleType { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<AvailableSize> AvailableSizes { get; set; }
    }
}
