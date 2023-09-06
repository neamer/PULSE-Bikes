namespace PULSE.Services.Data
{
    public class Gear : Product
    {
        public int? AvailableQty { get; set; }
        public virtual GearCategory? ProductCategory { get; set; }
    }
}
