using AutoMapper;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Servicings
{
    public class Cancelled : BaseState
    {
        public Cancelled(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }
    }
}
