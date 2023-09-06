using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Servicings
{
    public class PendingReview : BaseState
    {
        public PendingReview(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper) {}

        public override Model.Servicing SubmitOffer(ServicingOfferInsertRequest request)
        {
            var item = Mapper.Map(request, CurrentEntity);

            foreach (var partReq in request.ServicingParts)
            {
                var partDb = Mapper.Map<ServicingPart>(partReq);
                var part = Context.Parts.Find(partReq.ProductId);

                if(part == null)
                {
                    throw new Exception("Servicing Part Not Found");
                }

                partDb.ServicingId = item.Id;
                partDb.UnitPrice = part.Price;

                Context.ServicingParts.Add(partDb);
            }

            item.Status = (int)Model.ServicingState.PendingPayment;
            item.UpdatedAt = DateTime.Now;
            Context.SaveChanges();

            return Mapper.Map<Model.Servicing>(item);
        }

        public override Model.Servicing Cancel()
        {
            if (CurrentEntity == null) { return null; }

            CurrentEntity.Status = (int)Model.OrderState.Cancelled;
            CurrentEntity.UpdatedAt = DateTime.Now;

            Context.SaveChanges();

            return Mapper.Map<Model.Servicing>(CurrentEntity);
        }

        public override Model.Servicing Update(ServicingUpdateRequest request)
        {
            Mapper.Map(request, CurrentEntity);

            Context.SaveChanges();

            return Mapper.Map<Model.Servicing>(CurrentEntity);
        }
    }
}
