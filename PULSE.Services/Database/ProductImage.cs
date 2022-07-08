using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class ProductImage
    {
        public int ProductImageId { get; set; }
        public int? ProductId { get; set; }
        public byte[]? Image { get; set; }

        public virtual Product? Product { get; set; }
    }
}
