using AutoMapper;
using PULSE.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.StateMachines.Servicing
{
    public class Completed : BaseState
    {
        public Completed(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }
    }
}
