using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class BicycleSize
    {
        public BicycleSize()
        {
            //AvailableSizes = new HashSet<AvailableSize>();
            //OrderDetails = new HashSet<OrderDetail>();
        }

        public int BicycleSizeId { get; set; }
        public string? Size { get; set; }

        //public virtual ICollection<AvailableSize> AvailableSizes { get; set; }
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public override string ToString() => Size;
    }
}
