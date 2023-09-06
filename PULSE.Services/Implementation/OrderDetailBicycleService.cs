using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;
using PULSE.Services.StateMachines.Order;

namespace PULSE.Services.Implementation
{
    public class OrderDetailBicycleService : BaseCRUDService<Model.OrderDetail, Data.OrderDetailBicycle, BaseSearchObject, OrderDetailBicycleInsertRequest, OrderDetailsUpdateRequest>, IOrderDetailBicycleService
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
