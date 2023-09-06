namespace PULSE.Services.Data
{
    public partial class Servicing : AuditableEntity
    {
        public Servicing()
        {
            ServicingParts = new HashSet<ServicingPart>();
        }

        public string? ServicingNumber { get; set; }
        public int? CustomerId { get; set; }
        public int? PaymentId { get; set; }
        public string? CustomerRequest { get; set; }
        public int? Status { get; set; }
        public bool? OnlinePayment { get; set; }
        public decimal? LabourCost { get; set; }
        public string? OfferDetails { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Payment? Payment { get; set; }
        public virtual ICollection<ServicingPart> ServicingParts { get; set; }
    }
}
