namespace PULSE.Services.Data
{
    public abstract class ProductCategory : BaseEntity
    {
        public string? Name { get; set; }
        public string? Discriminator { get; set; }
    }
}
