using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class Gear : Product
    {
        public int? GearCategoryId { get; set; }
        public int? AvailableQty { get; set; }

        public virtual ProductCategory? GearCategory { get; set; }
    }
}
