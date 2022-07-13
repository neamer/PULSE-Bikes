using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class Gear : Product
    {
        public int? ProductCategoryId { get; set; }
        public int? AvailableQty { get; set; }

        public virtual ProductCategory? ProductCategory { get; set; }
    }
}
