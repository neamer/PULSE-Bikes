namespace PULSE.Services.Data
{
    public class PartCategory : ProductCategory
    {
        public PartCategory()
        {
            Part = new HashSet<Part>();
        }

        public virtual ICollection<Part> Part { get; set; }
    }
}
