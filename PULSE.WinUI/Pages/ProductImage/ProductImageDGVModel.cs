using PULSE.Model;
using PULSE.WinUI.Helpers;

namespace PULSE.WinUI.Pages.ProductImage
{
    public class ProductImageDGVModel
    {
        public int Id { get; set; }
        public Image? Image { get; set; }

        public ProductImageDGVModel() { }

        public ProductImageDGVModel(Model.ProductImage source)
        {
            Id = source.Id;
            Image = source.Data != null ? ImageHelper.FromByteToImage(source.Data) : null;
        }
    }
}
