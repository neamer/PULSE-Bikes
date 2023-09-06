namespace PULSE.Services.Data
{
    public class GearCategory : ProductCategory
    {
        public GearCategory()
        {
            Gear = new HashSet<Gear>();
        }

        public virtual ICollection<Gear> Gear { get; set; }
    }
}
