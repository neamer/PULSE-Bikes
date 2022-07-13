using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class BicycleUpsertRequest : ProductUpsertRequest
    {
        public decimal Weight { get; set; }
        public int ProductionYear { get; set; }
        public string WheelSize { get; set; }
    }
}
