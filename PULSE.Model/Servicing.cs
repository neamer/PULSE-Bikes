using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class Servicing
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
        public string? StatusName { get; set; }
        public bool? OnlinePayment { get; set; }
        public decimal? LabourCost { get; set; }
        public string? OfferDetails { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Payment? Payment { get; set; }
        public virtual ICollection<ServicingPart> ServicingParts { get; set; }

        public void CalcStatusName()
        {
            StatusName = ServicingStateHelper.GetNameFromState((ServicingState)Status);
        }
    }
}
