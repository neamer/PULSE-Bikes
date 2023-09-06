namespace PULSE.Model
{
    public class AuditableModel : BaseModel
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
