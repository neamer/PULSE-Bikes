using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class ServicingPartInsertRequest
    {
        public int ServicingId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
