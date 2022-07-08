using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.SearchObjects
{
    public class StaffSearchObject : BaseSearchObject
    {
        public string? Username { get; set; }
        public string? NameFTS { get; set; }
        public string? Email { get; set; }
        public bool? IncludeRoles { get; set; }
    }
}
