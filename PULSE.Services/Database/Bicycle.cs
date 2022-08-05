﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Database
{
    public class Bicycle : Product
    {
        public Bicycle()
        {
            AvailableSizes = new HashSet<AvailableSize>();
        }


        public decimal? Weight { get; set; }
        public int? ProductionYear { get; set; }
        public string? WheelSize { get; set; }

        public virtual BicycleCategory? ProductCategory { get; set; }
        public virtual ICollection<AvailableSize> AvailableSizes { get; set; }
    }
}