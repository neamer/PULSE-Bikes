namespace PULSE.Model
{
    public class ServicingPart
    {
        public int ServicingId { get; set; }
        public int ProductId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }

        public virtual Part Product { get; set; } = null!;
    }
}
