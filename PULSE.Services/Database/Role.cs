using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class Role
    {
        public Role()
        {
            staff = new HashSet<staff>();
        }

        public int RoleId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<staff> staff { get; set; }
    }
}
