namespace PULSE.Services.Data
{
    public partial class ServicingPart
    {
        public int ServicingId { get; set; }
        public int ProductId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Servicing Servicing { get; set; } = null!;
    }
}
