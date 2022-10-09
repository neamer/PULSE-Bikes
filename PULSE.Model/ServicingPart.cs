﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class ServicingPart
    {
        public int ServicingId { get; set; }
        public int ProductId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }

        public virtual Part Product { get; set; } = null!;
    }
}
