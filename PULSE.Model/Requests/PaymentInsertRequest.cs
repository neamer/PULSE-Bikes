﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model.Requests
{
    public class PaymentInsertRequest
    {
        public string Method { get; set; }
        public string? PaymentId { get; set; }
    }
}
