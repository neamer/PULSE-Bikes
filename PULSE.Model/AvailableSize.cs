namespace PULSE.Model
{
    public class AvailableSize : BaseModel
    {
        public int BicycleSizeId { get; set; }
        public int ProductId { get; set; }
        public int? AvailableQty { get; set; }

        public virtual BicycleSize BicycleSize { get; set; } = null!;

        public override string ToString()
        {
            return $"{BicycleSize} - {AvailableQty} available";
        }
    }
}
