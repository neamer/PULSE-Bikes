namespace PULSE.Services.Data
{
    public class BicycleCategory : ProductCategory
    {
        public BicycleCategory()
        {
            Bicycle = new HashSet<Bicycle>();
        }

        public virtual ICollection<Bicycle> Bicycle { get; set; }
    }
}
