using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ProductImages = new HashSet<ProductImage>();
            ServicingParts = new HashSet<ServicingPart>();
        }

        public int ProductId { get; set; }
        public int? BrandId { get; set; }
        public int? ProductCategoryId { get; set; }
        public string? ProductNumber { get; set; }
        public string? Model { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? Discriminator { get; set; }
        public byte[]? ThumbImage { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Brand? Brand { get; set; }
        //public virtual ProductCategory? ProductCategory { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ServicingPart> ServicingParts { get; set; }
    }
}
