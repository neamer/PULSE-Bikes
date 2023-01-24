using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.SearchObjects
{
    public class BicycleSearchObject : ProductSearchObject
    {
        public decimal? Weight { get; set; }
        public int? ProductionYear { get; set; }
        public List<int>? BicycleSizes { get; set; }
        public string? WheelSize { get; set; }

        public bool? IncludeSizes { get; set; }
    }
}
