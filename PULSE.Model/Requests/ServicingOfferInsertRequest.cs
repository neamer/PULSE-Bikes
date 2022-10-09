using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class ServicingOfferInsertRequest
    {
        public string OfferDetails { get; set; }
        public decimal LabourCost { get; set; }

        public virtual ICollection<ServicingPartBatchInsertRequest> ServicingParts { get; set; }
    }
}
