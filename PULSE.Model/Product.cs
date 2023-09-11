namespace PULSE.Model
{
    public class Product : AuditableModel
    {
        public Product()
        {
            Images = new HashSet<ProductImage>();
        }

        public int? BrandId { get; set; }
        public int? ProductCategoryId { get; set; }
        public string? ProductNumber { get; set; }
        public string? Model { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public byte[]? ThumbImage { get; set; }

        public virtual Brand? Brand { get; set; }
        public virtual ICollection<ProductImage> Images { get; set; }
    }
}
