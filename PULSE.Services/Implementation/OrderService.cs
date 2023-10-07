using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;
using PULSE.Services.StateMachines.Order;

namespace PULSE.Services.Implementation
{
    public class OrderService : BaseCRUDService<Model.OrderHeader, Data.OrderHeader, OrderSearchObject, OrderHeaderInsertRequest, OrderHeaderUpdateRequest>, IOrderService
    {
        public BaseState BaseState { get; set; }

        public OrderService(PULSEContext context, IMapper mapper, BaseState baseState) : base(context, mapper)
        {
            BaseState = baseState;
        }

        public override Model.OrderHeader Insert(OrderHeaderInsertRequest insert)
        {
            var state = BaseState.CreateState(Model.OrderState.Initial);

            return state.InsertEmployee(insert);
        }

        private Data.OrderHeader CreateDraftOrderForCustomer(int customerId)
        {
            var order = new Data.OrderHeader()
            {
                Status = Model.OrderState.Draft,
                CustomerId = customerId
            };

            Context.OrderHeaders.Add(order);
            Context.SaveChangesAsync();

            return order;
        }

        public Data.OrderHeader GetDraftOrderForCustomer(int customerId)
        {
            var order = Context.OrderHeaders.Where(item => item.CustomerId == customerId).First();

            return order == null
                ? CreateDraftOrderForCustomer(customerId)
                : order;
        }

        public override Model.OrderHeader Update(int id, OrderHeaderUpdateRequest update)
        {
            var item = Context.OrderHeaders.Find(id);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }


            var state = BaseState.CreateState((Model.OrderState)item.Status);
            state.CurrentEntity = item;

            return state.Update(update);
        }

        public bool Process(int id, PaymentInsertRequest req)
        {
            var item = Context.OrderHeaders.Include(q => q.OrderDetails).ThenInclude(q => q.Product).Where(x => x.Id == id).First();

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((Model.OrderState)item.Status);
            state.CurrentEntity = item;

            return state.Process(req);
        }

        public override IQueryable<OrderHeader> AddInclude(IQueryable<OrderHeader> query, OrderSearchObject search = null)
        {
            if (search?.IncludeDetails == true)
            {
                query = query.Include(q => q.OrderDetails);
            }

            if (search?.IncludePayment == true)
            {
                query = query.Include(q => q.Payment);
            }            
            
            if (search?.IncludeCustomer == true)
            {
                query = query.Include(q => q.Customer);
            }

            return query;
        }

        public override IQueryable<OrderHeader> AddFilter(IQueryable<OrderHeader> query, OrderSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.AnyField))
            {
                filteredQuery = filteredQuery.Where(x => x.OrderNumber.ToLower().Contains(search.AnyField.ToLower()));
            }

            if (search?.Status != null)
            {
                filteredQuery = filteredQuery.Where(x => x.Status == search.Status);
            }

            return filteredQuery;
        }
        public Model.OrderHeader GetDetails(int id)
        {
            var query = Context.Set<Data.OrderHeader>().Where(x => x.Id == id);

            query = query.Include(q => q.OrderDetails).ThenInclude(q => q.Product).Include(q => q.Payment).Include(q => q.ShippingInfo).Include(q => q.Customer);

            Data.OrderHeader entity;

            try
            {
                entity = query.First();
            }
            catch (Exception)
            {
                throw new Exception("Order Not Found");
            }

            foreach (var detail in entity.OrderDetails)
            {
                if (detail.Product is Data.Bicycle)
                {
                    (detail as Data.OrderDetailBicycle).BicycleSize = Context.BicycleSizes.Find((detail as Data.OrderDetailBicycle).BicycleSizeId);
                }
            }

            return Mapper.Map<Model.OrderHeader>(entity);
        }

        public Model.OrderDetail UpdateDetail(int id, OrderDetailsUpdateRequest req)
        {
            var detail = Context.OrderDetail.Find(id);

            if (detail == null)
            {
                throw new Exception("Order Detail Not Found");
            }

            var order = Context.OrderHeaders.Find(detail.OrderId);

            var state = BaseState.CreateState((Model.OrderState)order.Status);
            state.CurrentEntity = order;

            return state.UpdateOrderDetail(id, req);
        }

        public Model.OrderDetail DeleteDetail(int id)
        {
            var detail = Context.OrderDetail.Find(id);

            if (detail == null)
            {
                throw new Exception("Order Detail Not Found");
            }


            var order = Context.OrderHeaders.Find(detail.OrderId);

            var state = BaseState.CreateState((Model.OrderState)order.Status);
            state.CurrentEntity = order;

            return state.DeleteOrderDetail(id);
        }

        public bool DeleteShippingDetails(int id)
        {
            var order = Context.OrderHeaders.Include(q => q.ShippingInfo).Where(x => x.Id == id).First();

            if (order == null)
            {
                throw new Exception("Order Not Found");
            }

            if (order.ShippingInfo == null)
            {
                throw new Exception("Order Doesn't Have Shipping Details");
            }

            var state = BaseState.CreateState((Model.OrderState)order.Status);
            state.CurrentEntity = order;

            return state.DeleteShippingInfo();
        }

        public Model.OrderHeader Delete(int id)
        {
            var item = Context.OrderHeaders.Find(id);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((Model.OrderState)item.Status);
            state.CurrentEntity = item;

            return state.Delete();
        }


        public Model.OrderHeader Cancel(int id)
        {
            var item = Context.OrderHeaders.Include(q => q.OrderDetails).ThenInclude(q => q.Product).Where(x => x.Id == id).First();

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((Model.OrderState)item.Status);
            state.CurrentEntity = item;

            return state.Cancel();
        }


        public Model.OrderHeader Pack(int id)
        {
            var item = Context.OrderHeaders.Find(id);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((Model.OrderState)item.Status);
            state.CurrentEntity = item;

            state.Pack();

            return Mapper.Map<Model.OrderHeader>(item);

        }

        public Model.OrderHeader Ship(int id)
        {
            var item = Context.OrderHeaders.Find(id);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((Model.OrderState)item.Status);
            state.CurrentEntity = item;

            state.Ship();

            return Mapper.Map<Model.OrderHeader>(item);
        }

        public Model.OrderHeader Deliver(int id)
        {
            var item = Context.OrderHeaders.Find(id);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((Model.OrderState)item.Status);
            state.CurrentEntity = item;

            state.Deliver();

            return Mapper.Map<Model.OrderHeader>(item);
        }
    }
}
