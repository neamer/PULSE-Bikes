using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string? Method { get; set; }
        public DateTime? TimeOfPayment { get; set; }
    }
}
