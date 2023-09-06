namespace PULSE.Services.Data
{
    public class OrderDetailBicycle : OrderDetail
    {
        public int? BicycleSizeId { get; set; }

        public virtual BicycleSize? BicycleSize { get; set; }
    }
}
