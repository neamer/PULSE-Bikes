namespace PULSE.Services.Data
{
    public partial class BicycleSize : BaseEntity
    {
        public BicycleSize()
        {
            AvailableSizes = new HashSet<AvailableSize>();
            OrderDetails = new HashSet<OrderDetailBicycle>();
        }

        public string? Size { get; set; }

        public virtual ICollection<AvailableSize> AvailableSizes { get; set; }
        public virtual ICollection<OrderDetailBicycle> OrderDetails { get; set; }
    }
}
