using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class PartCategory
    {
        public PartCategory()
        {
            Parts = new HashSet<Part>();
        }

        public int PartCategoryId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}
