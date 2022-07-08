using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? BicycleSizeId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }

        public virtual BicycleSize? BicycleSize { get; set; }
        public virtual OrderHeader? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
