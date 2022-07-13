using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.SearchObjects
{
    public class ProductSearchObject : BaseSearchObject
    {
        public int? BrandId { get; set; }
        public string? ProductNumber { get; set; }
        public string? Model { get; set; }
        public decimal? Price { get; set; }

        public bool? IncludeBrand { get; set; }
        public bool? IncludeCategory { get; set; }
    }
}
