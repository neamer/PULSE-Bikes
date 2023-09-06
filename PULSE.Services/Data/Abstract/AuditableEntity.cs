namespace PULSE.Services.Data
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
