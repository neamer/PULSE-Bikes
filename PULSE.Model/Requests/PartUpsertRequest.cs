using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class PartUpsertRequest : ProductUpsertRequest
    {
        public int? AvailableQty { get; set; }
    }
}
