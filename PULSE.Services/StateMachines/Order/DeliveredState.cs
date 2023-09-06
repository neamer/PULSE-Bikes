using AutoMapper;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Order
{
    public class DeliveredState : BaseState
    {
        public DeliveredState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }
    }
}
