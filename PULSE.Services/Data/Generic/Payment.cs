namespace PULSE.Services.Data
{
    public partial class Payment : BaseEntity
    {
        public string? Method { get; set; }
        public string? PaymentId { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? TimeOfPayment { get; set; }
    }
}
