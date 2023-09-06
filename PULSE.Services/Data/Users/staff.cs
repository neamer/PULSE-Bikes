namespace PULSE.Services.Data
{
    public partial class staff : User
    {
        public int? RoleId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfEmployment { get; set; }

        public virtual Role? Role { get; set; }
    }
}
