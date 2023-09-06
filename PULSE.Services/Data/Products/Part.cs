namespace PULSE.Services.Data
{
    public class Part : Product
    {
        public int? AvailableQty { get; set; }
        public virtual PartCategory? ProductCategory { get; set; }
    }
}

