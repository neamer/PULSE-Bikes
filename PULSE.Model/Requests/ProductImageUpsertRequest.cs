namespace PULSE.Model.Requests
{
    public class ProductImageUpsertRequest
    {
        public int ProductId { get; set; }
        public byte[]? Data { get; set; }
    }
}
