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

namespace PULSE.Services.Implementation
{
    public class OrderDetailBicycleService : BaseCRUDService<Model.OrderDetail, Database.OrderDetailBicycle, BaseSearchObject, OrderDetailBicycleInsertRequest, OrderDetailsUpdateRequest>, IOrderDetailBicycleService
    {
        public BaseState BaseState { get; set; }

        public OrderDetailBicycleService(PULSEContext context, IMapper mapper, BaseState baseState) : base(context, mapper)
        {
            BaseState = baseState;
        }

        public override Model.OrderDetail Insert(OrderDetailBicycleInsertRequest insert)
        {
            var item = Context.OrderHeaders.Find(insert.OrderId);

            if(item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((Model.OrderState)item.Status);
            state.CurrentEntity = item;

            return state.AddBicycleDetail(insert);
        }
    }
}
