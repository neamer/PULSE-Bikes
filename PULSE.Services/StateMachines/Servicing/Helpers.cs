using PULSE.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.StateMachines.Servicing
{
    public class Helpers
    {
        public static bool ValidateParts(IEnumerable<ServicingPart> parts)
        {
            foreach (var item in parts)
            {
                if (item.Product == null || ((item.Product as Part).AvailableQty - item.Quantity) < 0)
                {
                    return false;
                }
                
            }

            return true;
        }
    }
}
