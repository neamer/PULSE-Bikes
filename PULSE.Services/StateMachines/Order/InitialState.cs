using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.StateMachines.Order
{
    public class InitialState : BaseState
    {
        public InitialState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }

        public override Model.OrderHeader InsertEmployee(OrderHeaderInsertRequest request)
        {
            var entity = Mapper.Map<Database.OrderHeader>(request);
            entity.OrderDetails = new List<OrderDetail>();

            //entity.TimeDelivered = DateTime.Now;
            //entity.TimeProcessed = DateTime.Now;
            //entity.TimePacked = DateTime.Now;
            //entity.TimeDelivered = DateTime.Now;

            CurrentEntity = entity;
            CurrentEntity.Status = (int)States.Draft;

            Context.OrderHeaders.Add(entity);

            Context.SaveChanges();

            foreach (var item in request.OrderDetails)
            {
                var detail = Mapper.Map<Database.OrderDetail>(item);
                detail.OrderId = entity.OrderId;
                Context.OrderDetails.Add(detail);
                Context.SaveChanges();
            }

            return Mapper.Map<Model.OrderHeader>(entity);
        }
    }
}
