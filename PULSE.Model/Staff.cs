using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public partial class Staff
    {
        public int StaffId { get; set; }
        public string? FirstName { get; set; }
        public string? FullName { get; set; }
        public string? RolesNames { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public bool? Status { get; set; }
        public string? StatusName { get; set; }
        public string? PhoneNumber { get; set; }
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
