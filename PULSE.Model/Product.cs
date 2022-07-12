using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class Product
    {
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
        }

        public int ProductId { get; set; }
        public int? BrandId { get; set; }
        public string? ProductNumber { get; set; }
        public string? Model { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public byte[]? ThumbImage { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
