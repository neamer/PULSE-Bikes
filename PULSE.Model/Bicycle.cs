namespace PULSE.Model
{
    public class Bicycle : Product
    {
        public decimal? Weight { get; set; }
        public int? ProductionYear { get; set; }
        public string? WheelSize { get; set; }

        public string formattedSizes => string.Join(", ", AvailableSizes.Select(s => s.BicycleSize));

        public virtual ProductCategory? ProductCategory { get; set; }
        public virtual ICollection<AvailableSize> AvailableSizes { get; set; }
    }
}
