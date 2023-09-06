namespace PULSE.Services.Data
{
    public partial class Customer : User
    {
        public Customer()
        {
            OrderHeaders = new HashSet<OrderHeader>();
            Servicings = new HashSet<Servicing>();
        }

        public int? ShippingInfoId { get; set; }

        public virtual ShippingInfo? ShippingInfo { get; set; }
        public virtual ICollection<OrderHeader> OrderHeaders { get; set; }
        public virtual ICollection<Servicing> Servicings { get; set; }
    }
}
