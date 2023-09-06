namespace PULSE.Model
{
    public class Gear : Product
    {
        public int? AvailableQty { get; set; }

        public virtual ProductCategory? ProductCategory { get; set; }
    }
}
