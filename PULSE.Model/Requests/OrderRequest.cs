namespace PULSE.Model.Requests;

public class OrderRequest
{
    public ShippingInfo? ShippingInfo { get; set; }
    public PaymentInsertRequest Payment { get; set; }
    
}