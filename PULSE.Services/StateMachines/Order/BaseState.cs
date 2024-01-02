using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Order
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

        public Data.OrderHeader CurrentEntity { get; set; }
        public OrderState CurrentState { get; set; }

        public PULSEContext Context { get; set; } = null;

        public virtual Model.OrderHeader InsertEmployee(OrderHeaderInsertRequest request)
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual Model.OrderHeader Update(OrderHeaderUpdateRequest request)
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual Model.OrderDetail AddBicycleDetail(OrderDetailBicycleInsertRequest item)
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual Model.OrderDetail AddGearDetail(OrderDetailsInsertRequest item)
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual Model.OrderDetail UpdateOrderDetail(int id, OrderDetailsUpdateRequest req)
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }
        public virtual Model.OrderDetail AddPartDetail(OrderDetailsInsertRequest item)
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual Model.OrderDetail DeleteOrderDetail(int id)
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }        
        
        public virtual bool DeleteShippingInfo()
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual Model.OrderHeader Delete()
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual bool Process(PaymentInsertRequest req, Model.ShippingInfo? shippingInfo)
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }        
        
        public virtual void Pack()
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual void Ship()
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual void Deliver()
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual void Collected()
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public virtual Model.OrderHeader Cancel()
        {
            throw new InvalidOperationException("The current state is unable to perform the requested action");
        }

        public BaseState CreateState(OrderState state)
        {
            switch (state)
            {
                case OrderState.Initial:
                    return ServiceProvider.GetService<InitialState>();
                case OrderState.Draft:
                    return ServiceProvider.GetService<DraftState>();
                case OrderState.Processed:
                    return ServiceProvider.GetService<ProcessedState>();
                case OrderState.Packed:
                    return ServiceProvider.GetService<PackedState>();
                case OrderState.Shipped:
                    return ServiceProvider.GetService<ShippedState>();
                case OrderState.Delivered:
                    return ServiceProvider.GetService<DeliveredState>();
                case OrderState.Cancelled:
                    return ServiceProvider.GetService<CancelledState>();
                default:
                    throw new InvalidOperationException("Order State Not supported");
            }
        }

        public virtual List<string> AllowedActions()
        {
            return new List<string>();
        }

    }
}
