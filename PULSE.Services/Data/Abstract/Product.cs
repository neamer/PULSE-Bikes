namespace PULSE.Services.Data
{
    public class Product : AuditableEntity
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Images = new HashSet<ProductImage>();
            ServicingParts = new HashSet<ServicingPart>();
        }

        public int? BrandId { get; set; }
        public int? ProductCategoryId { get; set; }
        public string? ProductNumber { get; set; }
        public string? Model { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? Discriminator { get; set; }
        public byte[]? ThumbImage { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductImage> Images { get; set; }
        public virtual ICollection<ServicingPart> ServicingParts { get; set; }
    }
}
