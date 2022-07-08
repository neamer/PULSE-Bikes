using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class BicycleType
    {
        public BicycleType()
        {
            Bicycles = new HashSet<Bicycle>();
        }

        public int BicycleTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Bicycle> Bicycles { get; set; }
    }
}
