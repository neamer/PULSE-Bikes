namespace PULSE.Model
{
    public class Payment : BaseModel
    {
        public string? Method { get; set; }
        public DateTime? TimeOfPayment { get; set; }
    }
}
