﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Database
{
    public class GearCategory : ProductCategory
    {
        public GearCategory()
        {
            Gear = new HashSet<Gear>();
        }

        public virtual ICollection<Gear> Gear { get; set; }
    }
}
