using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.StateMachines.Servicing
{
    public class InitialState : BaseState
    {
        public InitialState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }

        public override Model.Servicing RegisterServicing(RegisterServicingRequest request)
        {
            var item = Mapper.Map<Database.Servicing>(request);
            item.Status = (int)Model.ServicingState.PendingReview;
            item.CreatedAt = DateTime.Now;
            item.UpdatedAt = DateTime.Now;

            Context.Servicings.Add(item);
            Context.SaveChanges();

            return Mapper.Map<Model.Servicing>(item);
        }
    }
}
