using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class Payment
    {
        public Payment()
        {
            OrderHeaders = new HashSet<OrderHeader>();
            Servicings = new HashSet<Servicing>();
        }

        public int PaymentId { get; set; }
        public string? Method { get; set; }
        public DateTime? TimeOfPayment { get; set; }

        public virtual ICollection<OrderHeader> OrderHeaders { get; set; }
        public virtual ICollection<Servicing> Servicings { get; set; }
    }
}
