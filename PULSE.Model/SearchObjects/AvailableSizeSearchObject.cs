using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.SearchObjects
{
    public class AvailableSizeSearchObject : BaseSearchObject
    {
        public int? BicycleSizeId { get; set; }
        public int? ProductId { get; set; }
        public int? AvailableQty { get; set; }
    }
}
