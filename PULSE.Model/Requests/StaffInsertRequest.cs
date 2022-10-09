using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class StaffInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false)]
        [EmailAddress()]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string PhoneNumber { get; set; }

        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }
        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEmployment { get; set; }

        public int RoleID { get; set; }
    }
}
