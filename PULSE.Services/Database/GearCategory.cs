using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class GearCategory
    {
        public GearCategory()
        {
            Gears = new HashSet<Gear>();
        }

        public int GearCategoryId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Gear> Gears { get; set; }
    }
}
