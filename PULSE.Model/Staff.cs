namespace PULSE.Model
{
    public partial class Staff : User
    {
        public string? FullName { get; set; }
        public string? RolesNames { get; set; }
        public string? StatusName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfEmployment { get; set; }

        public virtual Role Role { get; set; }

        public void CalcFullName()
        {
            FullName = $"{FirstName} {LastName}";
        }

        public void CalcStatusName()
        {
            StatusName = (Status ?? false) ? "Active" : "Inactive";
        }
    }
}
