using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class ServicingPartBatchInsertRequest
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
