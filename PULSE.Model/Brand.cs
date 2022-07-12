using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class Brand
    {
        public Brand()
        {
            //Products = new HashSet<Product>();
        }

        public int BrandId { get; set; }
        public string? Name { get; set; }

        //public virtual ICollection<Product> Products { get; set; }
    }
}
