using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public class AvailableSize
    {
        public int BicycleSizeId { get; set; }
        public int ProductId { get; set; }
        public int? AvailableQty { get; set; }

        public virtual BicycleSize BicycleSize { get; set; } = null!;

        public override string ToString()
        {
            return $"{BicycleSize} - {AvailableQty} available";
        }
    }
}
