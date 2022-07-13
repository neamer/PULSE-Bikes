using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Database
{
    public class Part : Product
    {
        public int? AvailableQty { get; set; }
        public virtual PartCategory? ProductCategory { get; set; }
    }
}
