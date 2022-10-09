using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class RegisterServicingRequest
    {
        public string ServicingNumber { get; set; }
        public int CustomerId { get; set; }
        public string CustomerRequest { get; set; }
    }
}
