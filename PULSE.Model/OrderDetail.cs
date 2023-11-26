namespace PULSE.Model
{
    public class OrderDetail : BaseModel
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int ProductId { get; set; }
        public int? BicycleSizeId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public string? Discriminator { get; set; }

        public virtual BicycleSize? BicycleSize { get; set; }
        //public virtual OrderHeader? Order { get; set; }
        public virtual ProductAIO? Product { get; set; }
    }
}
