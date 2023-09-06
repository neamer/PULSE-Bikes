using AutoMapper;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Order
{
    public class PackedState : BaseState
    {
        public PackedState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
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

        public override void Ship()
        {
            CurrentEntity.Status = (int)Model.OrderState.Shipped;
            CurrentEntity.TimeShipped = DateTime.Now;
            Context.SaveChanges();
        }
    }
}
