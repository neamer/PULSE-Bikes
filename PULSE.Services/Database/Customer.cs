using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class Customer
    {
        public Customer()
        {
            OrderHeaders = new HashSet<OrderHeader>();
            Servicings = new HashSet<Servicing>();
        }

        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public int? ShippingInfoId { get; set; }
        public string? PasswordHash { get; set; }
        public string? PasswordSalt { get; set; }
        public bool? Status { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ShippingInfo? ShippingInfo { get; set; }
        public virtual ICollection<OrderHeader> OrderHeaders { get; set; }
        public virtual ICollection<Servicing> Servicings { get; set; }
    }
}
