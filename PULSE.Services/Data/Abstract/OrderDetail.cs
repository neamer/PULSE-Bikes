namespace PULSE.Services.Data
{
    public abstract class OrderDetail : BaseEntity
    {
        public int? OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public string? Discriminator { get; set; }

        public virtual OrderHeader? Order { get; set; }
        public virtual Product? Product { get; set; }
    }
}
