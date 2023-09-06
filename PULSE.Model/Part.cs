namespace PULSE.Model
{
    public class Part : Product
    {
        public int? AvailableQty { get; set; }

        public virtual ProductCategory? ProductCategory { get; set; }
    }
}
