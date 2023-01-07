using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class Bicycle : Product
    {
        public decimal? Weight { get; set; }
        public int? ProductionYear { get; set; }
        public string? WheelSize { get; set; }

        public virtual ProductCategory? ProductCategory { get; set; }
        public virtual ICollection<AvailableSize> AvailableSizes { get; set; }
    }
}
