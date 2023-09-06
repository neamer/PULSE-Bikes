using AutoMapper;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Servicings
{
    public class PendingServicing : BaseState
    {
        public PendingServicing(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {

        }

        public override Model.Servicing Completed()
        {
            if (CurrentEntity == null) { return null; }

            CurrentEntity.Status = (int)Model.ServicingState.Completed;
            CurrentEntity.UpdatedAt = DateTime.Now;

            Context.SaveChanges();

            return Mapper.Map<Model.Servicing>(CurrentEntity);
        }

        public override Model.Servicing Cancel()
        {
            if (CurrentEntity == null) { return null; }

            foreach (var item in CurrentEntity.ServicingParts)
            {
                (item.Product as Part).AvailableQty += item.Quantity;
            }
            CurrentEntity.Status = (int)Model.ServicingState.Cancelled;
            CurrentEntity.UpdatedAt = DateTime.Now;

            Context.SaveChanges();

            return Mapper.Map<Model.Servicing>(CurrentEntity);
        }
    }
}
