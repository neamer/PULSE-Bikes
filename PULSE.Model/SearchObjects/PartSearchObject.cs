using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.SearchObjects
{
    public class PartSearchObject : ProductSearchObject
    {
        public int? ProductCategoryId { get; set; }
        public int? AvailableQty { get; set; }
    }
}
