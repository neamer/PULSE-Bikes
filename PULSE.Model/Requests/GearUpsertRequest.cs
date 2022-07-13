using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class GearUpsertRequest : ProductUpsertRequest
    {
        public int? AvailableQty { get; set; }
    }
}
