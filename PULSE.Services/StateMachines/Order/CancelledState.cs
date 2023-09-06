using AutoMapper;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Order
{
    public class CancelledState : BaseState
    {
        public CancelledState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }
    }
}
