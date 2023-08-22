﻿using PULSE.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.StateMachines.Order
{
    public class Helpers
    {

        public static bool ValidateOrder(PULSEContext Context, IEnumerable<OrderDetail> details)
        {
            if(details.Count() == 0) { return false; }

            foreach (var item in details)
            {
                switch (item.Discriminator)
                {
                    case "Part":

                        var detailProductP = Context.Parts.Find(item.ProductId);

                        if (detailProductP == null || (detailProductP.AvailableQty - item.Quantity) < 0)
                        {
                            return false;
                        }
                        break;

                    case "Gear":
                        var detailProductG = Context.Gear.Find(item.ProductId);

                        if (detailProductG == null || (detailProductG.AvailableQty - item.Quantity) < 0)
                        {
                            return false;
                        }
                        break;

                    case "Bicycle":
                        var detailProductB = Context.Bicycles.Find(item.ProductId);
                        var detailSize = Context.AvailableSizes.Find((item as OrderDetailBicycle).BicycleSizeId, item.ProductId);

                        if (detailProductB == null || detailSize == null || (detailSize.AvailableQty - item.Quantity) <- 0)
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
            }

            return true;
        }
    }
}