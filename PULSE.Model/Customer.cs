namespace PULSE.Model
{
    public class Customer : AuditableModel
    {
        public Customer()
        {
            //OrderHeaders = new HashSet<OrderHeader>();
            //Servicings = new HashSet<Servicing>();
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public int? ShippingInfoId { get; set; }
        public bool? Status { get; set; }
        public string? PhoneNumber { get; set; }

        //public virtual ShippingInfo? ShippingInfo { get; set; }
        //public virtual ICollection<OrderHeader> OrderHeaders { get; set; }
        //public virtual ICollection<Servicing> Servicings { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
