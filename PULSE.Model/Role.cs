namespace PULSE.Model
{
    public partial class Role : BaseModel
    {
        public string? Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
