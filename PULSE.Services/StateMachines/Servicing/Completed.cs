using AutoMapper;
using PULSE.Services.Data;

namespace PULSE.Services.StateMachines.Servicings
{
    public class Completed : BaseState
    {
        public Completed(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }
    }
}
