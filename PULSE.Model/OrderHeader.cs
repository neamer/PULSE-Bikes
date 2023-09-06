namespace PULSE.Model
{
    public class OrderHeader : BaseModel
    {
        public OrderHeader()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string? OrderNumber { get; set; }
        public int? CustomerId { get; set; }
        public int? PaymentId { get; set; }
        public int? ShippingInfoId { get; set; }
        public int? Status { get; set; }
        public string? StatusName { get; set; }
        public DateTime? TimeProcessed { get; set; }
        public DateTime? TimePacked { get; set; }
        public DateTime? TimeShipped { get; set; }
        public DateTime? TimeDelivered { get; set; }
        public bool? OnlineOrder { get; set; }
        public bool? Delivery { get; set; }
        public decimal? ShippingConst { get; set; }
        public int NoOfItems { get; set; }
        public decimal Total { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Payment? Payment { get; set; }
        public virtual ShippingInfo? ShippingInfo { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public void CalcNoOfItems() => NoOfItems = OrderDetails.Count;
        public void CalcTotal()
        {
            Total = 0;

            foreach (var item in OrderDetails)
            {
                Total += (item.UnitPrice ?? 0) * (item.Quantity ?? 0);
            }
        }
        public void CalcStatusName()
        {
            StatusName = OrderStateHelper.GetNameFromState((OrderState)Status);
        }
    }
}
