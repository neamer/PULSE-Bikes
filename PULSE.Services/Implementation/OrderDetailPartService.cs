using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;
using PULSE.Services.StateMachines.Order;

namespace PULSE.Services.Implementation
{
    public class OrderDetailPartService : BaseCRUDService<Model.OrderDetail, Data.OrderDetailPart, BaseSearchObject, OrderDetailsInsertRequest, OrderDetailsUpdateRequest>, IOrderDetailPartService
    {
        public BaseState BaseState { get; set; }

        public OrderDetailPartService(PULSEContext context, IMapper mapper, BaseState baseState) : base(context, mapper)
        {
            BaseState = baseState;
        }

        public override Model.OrderDetail Insert(OrderDetailsInsertRequest insert)
        {
            var item = Context.OrderHeaders.Find(insert.OrderId);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((Model.OrderState)item.Status);
            state.CurrentEntity = item;

            return state.AddPartDetail(insert);
        }
    }
}
