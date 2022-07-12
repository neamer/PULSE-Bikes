using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class Part : Product
    {
        public int? PartCategoryId { get; set; }
        public int? AvailableQty { get; set; }

        public virtual ProductCategory? PartCategory { get; set; }
    }
}
