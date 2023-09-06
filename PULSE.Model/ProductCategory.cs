namespace PULSE.Model
{
    public class ProductCategory : BaseModel
    {
        public string Name { get; set; }

        public override string ToString() => Name.ToString();
    }
}
