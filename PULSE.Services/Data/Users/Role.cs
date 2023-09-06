namespace PULSE.Services.Data
{
    public partial class Role : BaseEntity
    {
        public Role()
        {
            staff = new HashSet<staff>();
        }

        public string? Name { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
