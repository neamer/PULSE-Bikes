using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.WinUI.Pages.Orders
{
    public class ProductDetailDGVItem
    {
        public int OrderDetailId { get; set; }
        public string ProductNumber { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
        public int? BicycleSizeId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Discriminator { get; set; }

        public ProductDetailDGVItem()
        {

        }

        public ProductDetailDGVItem(Model.OrderDetail detail)
        {
            OrderDetailId = detail.Id;
            ProductNumber = detail.Product.ProductNumber;
            Model = detail.Product.Model;
            ProductId = detail.Product.Id;
            UnitPrice = detail.Product.Price ?? 0;
            Size = detail.BicycleSize?.Size ?? "-";
            BicycleSizeId = detail.BicycleSizeId;
            Quantity = detail.Quantity ?? 0;
            Discriminator = detail.Discriminator;
        }

        public ProductDetailDGVItem(Model.ServicingPart detail)
        {
            ProductNumber = detail.Product.ProductNumber;
            Model = detail.Product.Model;
            ProductId = detail.Product.Id;
            UnitPrice = detail.Product.Price ?? 0;
            Quantity = detail.Quantity ?? 0;
        }
    }
}
