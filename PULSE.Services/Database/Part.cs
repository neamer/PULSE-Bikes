using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class Part
    {
        public Part()
        {
            ServicingParts = new HashSet<ServicingPart>();
        }

        public int ProductId { get; set; }
        public int? PartCategoryId { get; set; }
        public int? AvailableQty { get; set; }

        public virtual PartCategory? PartCategory { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual ICollection<ServicingPart> ServicingParts { get; set; }
    }
}
