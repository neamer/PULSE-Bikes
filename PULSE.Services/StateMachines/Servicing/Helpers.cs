using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Servicings
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
