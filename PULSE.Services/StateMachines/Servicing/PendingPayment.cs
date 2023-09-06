using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Servicings
{
    public class PendingPayment : BaseState
    {
        public PendingPayment(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }

        public override Model.Servicing RegisterAcceptedOffer(PaymentInsertRequest req)
        {
            if(Helpers.ValidateParts(CurrentEntity.ServicingParts))
            {
                decimal total = 0;

                foreach (var item in CurrentEntity.ServicingParts)
                {
                    (item.Product as Part).AvailableQty -= item.Quantity;
                    total += (item.UnitPrice ?? 0) * (item.Quantity ?? 0);
                }

                var payment = Mapper.Map<Data.Payment>(req);
                payment.Amount = total;
                Context.Add(payment);
                Context.SaveChanges();

                CurrentEntity.PaymentId = payment.Id;
                CurrentEntity.Status = (int)Model.ServicingState.PendingServicing;
                CurrentEntity.UpdatedAt = DateTime.Now;

                Context.SaveChanges();

                return Mapper.Map<Model.Servicing>(CurrentEntity);
            }

            throw new Exception("Could not validate Parts! Check avaliable quantity.");
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
