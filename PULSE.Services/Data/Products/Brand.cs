namespace PULSE.Services.Data
{
    public partial class Brand : BaseEntity
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public string? Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
