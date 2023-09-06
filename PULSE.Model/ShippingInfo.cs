namespace PULSE.Model
{
    public class ShippingInfo : BaseModel
    {
        public string? Country { get; set; }
        public string? StateOrProvince { get; set; }
        public string? City { get; set; }
        public string? ZipCode { get; set; }
        public string? StreetAddress { get; set; }
    }
}
