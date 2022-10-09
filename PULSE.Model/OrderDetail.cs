using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? BicycleSizeId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public string? Discriminator { get; set; }

        public virtual BicycleSize? BicycleSize { get; set; }
        //public virtual OrderHeader? Order { get; set; }
        public virtual ProductAIO? Product { get; set; }
    }
}
