using AutoMapper;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Order
{
    public class ShippedState : BaseState
    {
        public ShippedState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper) {}

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

        public override void Deliver()
        {
            CurrentEntity.Status = (int)Model.OrderState.Delivered;
            CurrentEntity.TimeDelivered = DateTime.Now;
            Context.SaveChanges();
        }
    }
}
