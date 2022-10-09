using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Model
{
    public enum OrderState
    {
        Initial,
        Cart,
        Draft,
        Processed,
        Packed,
        Shipped,
        Collected,
        Delivered,
        Cancelled
    }

    public class OrderStateHelper
    {

        public static List<string> GetStateNames()
        {
            return new List<string>()
            {
                "INITIAL",
                "CART",
                "DRAFT",
                "PROCESSED",
                "PACKED",
                "SHIPPED",
                "COLLECTED",
                "DELIVERED",
                "CANCELLED",
            };
        }

        public static string GetNameFromState(OrderState state)
        {
            switch (state)
            {
                case OrderState.Initial:
                    return "INITIAL";
                    break;
                case OrderState.Cart:
                    return "CART";
                    break;
                case OrderState.Draft:
                    return "DRAFT";
                    break;
                case OrderState.Processed:
                    return "PROCESSED";
                    break;
                case OrderState.Packed:
                    return "PACKED";
                    break;
                case OrderState.Shipped:
                    return "SHIPPED";
                    break;
                case OrderState.Collected:
                    return "COLLECTED";
                    break;
                case OrderState.Delivered:
                    return "DELIVERED";
                    break;
                case OrderState.Cancelled:
                    return "CANCELLED";
                    break;
                default:
                    return "";
                    break;
            }
        }

        public static OrderState GetStateFromName(string name)
        {
            switch (name)
            {
                case "INITIAL":
                    return OrderState.Initial;
                    break;
                case "CART":
                    return OrderState.Cart;
                    break;
                case "DRAFT":
                    return OrderState.Draft;
                    break;
                case "PROCESSED":
                    return OrderState.Processed;
                    break;
                case "PACKED":
                    return OrderState.Packed;
                    break;
                case "SHIPPED":
                    return OrderState.Shipped;
                    break;
                case "COLLECTED":
                    return OrderState.Collected;
                    break;
                case "DELIVERED":
                    return OrderState.Delivered;
                    break;
                case "CANCELLED":
                    return OrderState.Cancelled;
                    break;
                default:
                    return OrderState.Cancelled;
                    break;
            }
        }
    }
}
