using PULSE.Model;

namespace PULSE.Services.Data
{
    public partial class OrderHeader : BaseEntity
    {
        public OrderHeader()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string? OrderNumber { get; set; }
        public int? CustomerId { get; set; }
        public int? StaffId { get; set; }
        public int? PaymentId { get; set; }
        public int? ShippingInfoId { get; set; }
        public OrderState? Status { get; set; }
        public DateTime? TimeProcessed { get; set; }
        public DateTime? TimePacked { get; set; }
        public DateTime? TimeShipped { get; set; }
        public DateTime? TimeDelivered { get; set; }
        public bool? OnlineOrder { get; set; }
        public bool? Delivery { get; set; }
        public decimal? ShippingConst { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual staff? Staff { get; set; }
        public virtual Payment? Payment { get; set; }
        public virtual ShippingInfo? ShippingInfo { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        
        public decimal Total()
        {
            decimal result = 0;

            foreach (var item in OrderDetails)
            {
                result += (item.UnitPrice ?? 0) * (item.Quantity ?? 0);
            }

            return result;
        }
    }
}
