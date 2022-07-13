using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Database
{
    public class PartCategory : ProductCategory
    {
        public PartCategory()
        {
            Part = new HashSet<Part>();
        }

        public virtual ICollection<Part> Part { get; set; }
    }
}
