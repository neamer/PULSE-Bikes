using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.SearchObjects
{
    public class StaffSearchObject : BaseSearchObject
    {
        public string? AnyField { get; set; }
        public int? RoleId { get; set; }
        public bool? Status { get; set; }
        public bool? IncludeRole { get; set; }
    }
}
