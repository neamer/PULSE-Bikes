using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.SearchObjects
{
    public class PartSearchObject : ProductSearchObject
    {
        public int? PartCategoryId { get; set; }
        public int? AvailableQty { get; set; }
    }
}
