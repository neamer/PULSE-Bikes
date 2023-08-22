﻿using AutoMapper;
using PULSE.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.StateMachines.Order
{
    public class ProcessedState : BaseState
    {
        public ProcessedState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }

        public override Model.OrderHeader Cancel()
        {
            if (CurrentEntity == null) { return null; }

            CurrentEntity.Status = (int)Model.OrderState.Cancelled;

            foreach (var item in CurrentEntity.OrderDetails)
            {
                switch (item.Discriminator)
                {
                    case "Part":
                        (item.Product as Part).AvailableQty += item.Quantity;
                        
                        break;

                    case "Gear":
                        (item.Product as Gear).AvailableQty += item.Quantity;

                        break;

                    case "Bicycle":
                        var detailSize = Context.AvailableSizes.Find((item as OrderDetailBicycle).BicycleSizeId, item.ProductId);

                        detailSize.AvailableQty += item.Quantity;
                        break;
                    default:
                        break;
                }
            }


            Context.SaveChanges();

            return Mapper.Map<Model.OrderHeader>(CurrentEntity);
        }

        public override void Pack()
        {
            CurrentEntity.Status = (int)Model.OrderState.Packed;
            CurrentEntity.TimePacked = DateTime.Now;
            Context.SaveChanges();
        }
    }
}