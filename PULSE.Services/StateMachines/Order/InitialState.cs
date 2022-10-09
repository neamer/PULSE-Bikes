using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.StateMachines.Order
{
    public class InitialState : BaseState
    {
        public InitialState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }

        public override Model.OrderHeader InsertEmployee(OrderHeaderInsertRequest request)
        {
            var entity = Mapper.Map<Database.OrderHeader>(request);
            entity.OrderDetails = new List<OrderDetail>();

            CurrentEntity = entity;
            CurrentEntity.Status = (int)Model.OrderState.Draft;

            if (request.ShippingInfo != null)
            {
                var shippingInfo = Mapper.Map<Database.ShippingInfo>(request.ShippingInfo);

                Context.ShippingInfos.Add(shippingInfo);
                Context.SaveChanges();

                entity.ShippingInfoId = shippingInfo.ShippingInfoId;
            }

            Context.OrderHeaders.Add(entity);

            Context.SaveChanges();

            foreach (var item in request.OrderDetails)
            {
                switch (item.Discriminator)
                {
                    case "Part":

                        var detailProductP = Context.Parts.Find(item.ProductId);
                        if(detailProductP != null)
                        {
                            var detailP = Mapper.Map<Database.OrderDetailPart>(item);
                            detailP.OrderId = entity.OrderId;
                            detailP.UnitPrice = detailProductP.Price;
                            Context.OrderDetailParts.Add(detailP);
                            Context.SaveChanges();
                        }
                        break;

                    case "Gear":
                        var detailProductG = Context.Gear.Find(item.ProductId);
                        if (detailProductG != null)
                        {
                            var detailG = Mapper.Map<Database.OrderDetailGear>(item);
                            detailG.OrderId = entity.OrderId;
                            detailG.UnitPrice = detailProductG.Price;
                            Context.OrderDetailGear.Add(detailG);
                            Context.SaveChanges();
                        }
                        break;

                    case "Bicycle":
                        var detailProductB = Context.Bicycles.Find(item.ProductId);
                        if (detailProductB != null)
                        {
                            var detailB = Mapper.Map<Database.OrderDetailBicycle>(item);
                            detailB.OrderId = entity.OrderId;
                            detailB.UnitPrice = detailProductB.Price;
                            Context.OrderDetailBicycles.Add(detailB);
                            Context.SaveChanges();
                        }
                        break;
                    default:
                        break;
                }
                
            }

            return Mapper.Map<Model.OrderHeader>(entity);
        }
    }
}
