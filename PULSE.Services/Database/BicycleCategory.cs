using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Database
{
    public class BicycleCategory : ProductCategory
    {
        public BicycleCategory()
        {
            Bicycle = new HashSet<Bicycle>();
        }

        public virtual ICollection<Bicycle> Bicycle { get; set; }
    }
}
