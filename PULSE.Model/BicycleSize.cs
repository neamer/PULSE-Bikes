namespace PULSE.Model
{
    public class BicycleSize : BaseModel
    {
        public BicycleSize()
        {
            //AvailableSizes = new HashSet<AvailableSize>();
            //OrderDetails = new HashSet<OrderDetail>();
        }

        public string? Size { get; set; }

        //public virtual ICollection<AvailableSize> AvailableSizes { get; set; }
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public override string ToString() => Size;
    }
}
