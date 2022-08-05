using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PULSE.Model.Requests;
using PULSE.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.StateMachines.Order
{
    public class BaseState
    {
        public enum States 
        {
            Initial,
            Cart,
            Draft,
            Processed,
            Packed,
            Shipped,
            Collected,
            Delivered,
            Cancelled
        }

        public IMapper Mapper { get; set; }
        public IServiceProvider ServiceProvider { get; set; }
        public BaseState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
        {
            Context = context;
            ServiceProvider = serviceProvider;
            Mapper = mapper;
        }

        public Database.OrderHeader CurrentEntity { get; set; }
        public States CurrentState { get; set; }

        public PULSEContext Context { get; set; } = null;

        public virtual Model.OrderHeader InsertEmployee(OrderHeaderInsertRequest request)
        {
            throw new Exception("Not allowed");
        }

        public virtual Model.OrderHeader Update(OrderHeaderUpdateRequest request)
        {
            throw new Exception("Not allowed");
        }

        public virtual void Process(PaymentInsertRequest req)
        {
            throw new Exception("Not allowed");
        }        
        
        public virtual void Pack()
        {
            throw new Exception("Not allowed");
        }

        public virtual void Ship()
        {
            throw new Exception("Not allowed");
        }

        public virtual void Deliver()
        {
            throw new Exception("Not allowed");
        }

        public virtual void Collected()
        {
            throw new Exception("Not allowed");
        }

        public virtual void Cancel()
        {
            throw new Exception("Not allowed");
        }

        public BaseState CreateState(States state)
        {
            switch (state)
            {
                case States.Initial:
                    return ServiceProvider.GetService<InitialState>();
                    break;
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
