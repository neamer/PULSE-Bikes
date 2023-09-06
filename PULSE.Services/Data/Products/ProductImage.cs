namespace PULSE.Services.Data
{
    public partial class ProductImage : AuditableEntity
    {
        public byte[]? Data { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }
    }
}
