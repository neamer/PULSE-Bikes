﻿using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class ShippingInfo
    {
        public ShippingInfo()
        {
            Customers = new HashSet<Customer>();
            OrderHeaders = new HashSet<OrderHeader>();
        }

        public int ShippingInfoId { get; set; }
        public string? Country { get; set; }
        public string? StateOrProvince { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? StreetAddress { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<OrderHeader> OrderHeaders { get; set; }
    }
}
