using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class AvailableSizeInsertRequest
    {
        public int ProductId { get; set; }
        public int BicycleSizeId { get; set; }
        public int AvailableQty { get; set; }
    }
}
