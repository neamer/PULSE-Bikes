using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.SearchObjects
{
    public class ServicingSearchObject : BaseSearchObject
    {
        public string? AnyField { get; set; }
        public int? Status { get; set; }

        public bool? IncludePayment { get; set; }
        public bool? IncludeCustomer { get; set; }
        public bool? IncludeParts { get; set; }
    }
}
