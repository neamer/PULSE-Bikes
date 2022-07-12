using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public int? ProductId { get; set; }
        public byte[]? Image { get; set; }
    }
}
