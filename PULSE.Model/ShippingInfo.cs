using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class ShippingInfo
    {
        public int ShippingInfoId { get; set; }
        public string? Country { get; set; }
        public string? StateOrProvince { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? StreetAddress { get; set; }
    }
}
