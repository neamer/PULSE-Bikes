using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class Servicing
    {
        public Servicing()
        {
            ServicingParts = new HashSet<ServicingPart>();
        }

        public int ServicingId { get; set; }
        public string? ServicingNumber { get; set; }
        public int? CustomerId { get; set; }
        public int? PaymentId { get; set; }
        public string? CustomerRequest { get; set; }
        public int? Status { get; set; }
        public bool? OnlinePayment { get; set; }
        public decimal? LabourCost { get; set; }
        public string? OfferDetails { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Payment? Payment { get; set; }
        public virtual ICollection<ServicingPart> ServicingParts { get; set; }
    }
}
