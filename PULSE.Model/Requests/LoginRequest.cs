using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class LoginRequest
    {
        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }
        [MinLength(4)]
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
    }
}
