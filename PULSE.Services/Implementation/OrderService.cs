using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Database;
using PULSE.Services.Interfaces;
using PULSE.Services.StateMachines.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PULSE.Services.StateMachines.Order.BaseState;

namespace PULSE.Services.Implementation
{
    public class OrderService : BaseCRUDService<Model.OrderHeader, Database.OrderHeader, OrderSearchObject, OrderHeaderInsertRequest, OrderHeaderUpdateRequest>, IOrderService
    {
        public BaseState BaseState { get; set; }

        public OrderService(PULSEContext context, IMapper mapper, BaseState baseState) : base(context, mapper)
        {
            BaseState = baseState;
        }

        public override Model.OrderHeader Insert(OrderHeaderInsertRequest insert)
        {
            var state = BaseState.CreateState(BaseState.States.Initial);

            return state.InsertEmployee(insert);
        }

        public override Model.OrderHeader Update(int id, OrderHeaderUpdateRequest update)
        {
            var item = Context.OrderHeaders.Find(id);

            var state = BaseState.CreateState((States)item.Status);
            state.CurrentEntity = item;

            return state.Update(update);
        }

        public void Process(int id, PaymentInsertRequest req)
        {
            var item = Context.OrderHeaders.Find(id);

            var state = BaseState.CreateState((States)item.Status);
            state.CurrentEntity = item;

            state.Process(req);
        }
    }
}
