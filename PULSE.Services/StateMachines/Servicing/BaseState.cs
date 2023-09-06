using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PULSE.Model.Requests;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Servicings
{
    public class BaseState
    {
        public IMapper Mapper { get; set; }
        public IServiceProvider ServiceProvider { get; set; }
        public BaseState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
        {
            Context = context;
            ServiceProvider = serviceProvider;
            Mapper = mapper;
        }

        public Servicing CurrentEntity { get; set; }
        public Model.ServicingState CurrentState { get; set; }

        public PULSEContext Context { get; set; } = null;

        public virtual Model.Servicing RegisterServicing(RegisterServicingRequest request)
        {
            throw new Exception("Not allowed");
        }

        public virtual Model.Servicing SubmitOffer(ServicingOfferInsertRequest request)
        {
            throw new Exception("Not allowed");
        }        
        
        public virtual Model.Servicing Update(ServicingUpdateRequest request)
        {
            throw new Exception("Not allowed");
        }

        public virtual Model.Servicing Cancel()
        {
            throw new Exception("Not allowed");
        }        
        
        public virtual Model.Servicing RegisterAcceptedOffer(PaymentInsertRequest req)
        {
            throw new Exception("Not allowed");
        }
        
        public virtual Model.Servicing Completed()
        {
            throw new Exception("Not allowed");
        }

        public BaseState CreateState(Model.ServicingState state)
        {
            switch (state)
            {
                case Model.ServicingState.Initial:
                    return ServiceProvider.GetService<InitialState>();
                case Model.ServicingState.PendingReview:
                    return ServiceProvider.GetService<PendingReview>();
                case Model.ServicingState.PendingPayment:
                    return ServiceProvider.GetService<PendingPayment>();
                case Model.ServicingState.PendingServicing:
                    return ServiceProvider.GetService<PendingServicing>();
                case Model.ServicingState.Completed:
                    return ServiceProvider.GetService<Completed>();
                case Model.ServicingState.Cancelled:
                    return ServiceProvider.GetService<Cancelled>();
                default:
                    throw new Exception("Not supported");
            }
        }

        public virtual List<string> AllowedActions()
        {
            return new List<string>();
        }

    }
}
