namespace PULSE.Model
{
    public class Brand : BaseModel
    {
        public Brand()
        {
            //Products = new HashSet<Product>();
        }

        public string? Name { get; set; }

        //public virtual ICollection<Product> Products { get; set; }

        public override string ToString() => Name.ToString();
    }
}
