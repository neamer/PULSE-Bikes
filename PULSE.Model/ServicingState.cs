namespace PULSE.Model
{

    public enum ServicingState
    {
        Initial,
        PendingReview,
        PendingPayment,
        PendingServicing,
        Completed,
        Cancelled
    }

    public class ServicingStateHelper
    {

        public static List<string> GetStateNames()
        {
            return new List<string>()
            {
                "PENDING REVIEW",
                "PENDING PAYMENT",
                "PENDING SERVICING",
                "COMPLETE",
                "CANCELLED",
            };
        }

        public static string GetNameFromState(ServicingState state)
        {
            switch (state)
            {
                case ServicingState.Initial:
                    return "INITIAL";
                    break;
                case ServicingState.PendingReview:
                    return "PENDING REVIEW";
                    break;
                case ServicingState.PendingPayment:
                    return "PENDING PAYMENT";
                    break;
                case ServicingState.PendingServicing:
                    return "PENDING SERVICING";
                    break;
                case ServicingState.Completed:
                    return "COMPLETE";
                    break;
                case ServicingState.Cancelled:
                    return "CANCELLED";
                    break;
                default:
                    return "";
                    break;
            }
        }

        public static ServicingState GetStateFromName(string name)
        {
            switch (name)
            {
                case "INITIAL":
                    return ServicingState.Initial;
                    break;
                case "PENDING REVIEW":
                    return ServicingState.PendingReview;
                    break;
                case "PENDING PAYMENT":
                    return ServicingState.PendingPayment;
                    break;
                case "PENDING SERVICING":
                    return ServicingState.PendingServicing;
                    break;
                case "COMPLETE":
                    return ServicingState.Completed;
                    break;
                case "CANCELLED":
                    return ServicingState.Cancelled;
                    break;
                default:
                    return ServicingState.Initial;
                    break;
            }
        }
    }
}
