using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.StateMachines.Servicing
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

        public Database.Servicing CurrentEntity { get; set; }
        public ServicingState CurrentState { get; set; }

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

        public BaseState CreateState(ServicingState state)
        {
            switch (state)
            {
                case ServicingState.Initial:
                    return ServiceProvider.GetService<InitialState>();
                    break;
                case ServicingState.PendingReview:
                    return ServiceProvider.GetService<PendingReview>();
                    break;
                case ServicingState.PendingPayment:
                    return ServiceProvider.GetService<PendingPayment>();
                    break;
                case ServicingState.PendingServicing:
                    return ServiceProvider.GetService<PendingServicing>();
                    break;
                case ServicingState.Completed:
                    return ServiceProvider.GetService<Completed>();
                    break;
                case ServicingState.Cancelled:
                    return ServiceProvider.GetService<Cancelled>();
                    break;
                default:
                    throw new Exception("Not supported");
                    break;
            }
        }

        public virtual List<string> AllowedActions()
        {
            return new List<string>();
        }

    }
}
