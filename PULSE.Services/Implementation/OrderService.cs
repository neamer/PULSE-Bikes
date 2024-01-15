using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;
using PULSE.Services.StateMachines.Order;
using PULSE.Services.Utils;
using Bicycle = PULSE.Model.Bicycle;
using OrderDetail = PULSE.Model.OrderDetail;
using OrderHeader = PULSE.Model.OrderHeader;

namespace PULSE.Services.Implementation
{
    public class OrderService : BaseCRUDService<OrderHeader, Data.OrderHeader, OrderSearchObject, OrderHeaderInsertRequest, OrderHeaderUpdateRequest>, IOrderService
    {
        private BaseState BaseState { get; }
        
        private IBicycleService BicycleService { get; }
        private IGearService GearService { get; }
        private IPartService PartService { get; }

        public OrderService(PULSEContext context, 
            IMapper mapper, 
            BaseState baseState, 
            IBicycleService bicycleService, 
            IGearService gearService, 
            IPartService partService) : base(context, mapper)
        {
            BaseState = baseState;
            BicycleService = bicycleService;
            GearService = gearService;
            PartService = partService;
        }

        public override OrderHeader Insert(OrderHeaderInsertRequest insert)
        {
            var state = BaseState.CreateState(OrderState.Initial);

            return state.InsertEmployee(insert);
        }

        private Data.OrderHeader CreateDraftOrderForCustomer(int customerId)
        {
            var order = new Data.OrderHeader()
            {
                Status = OrderState.Draft,
                CustomerId = customerId
            };

            Context.OrderHeaders.Add(order);
            Context.SaveChanges();

            return order;
        }

        public Data.OrderHeader GetDraftOrderForCustomer(int customerId)
        {
            var order = Context.OrderHeaders
                .Include(element => element.OrderDetails)
                .ThenInclude(od => od.Product)
                .FirstOrDefault(item => item.Status == OrderState.Draft && item.CustomerId == customerId);

            return order == null
                ? CreateDraftOrderForCustomer(customerId)
                : order;
        }

        private void enrichOrderDetail(OrderDetail order)
        {
            if (order.Discriminator == "Bicycle")
            {
                order.Product = Mapper.Map<ProductAIO>(this.BicycleService.GetById(order.ProductId, IncludeAll.Bicycle));
            } else if (order.Discriminator == "Gear")
            {
                order.Product = Mapper.Map<ProductAIO>(this.GearService.GetById(order.ProductId, IncludeAll.Gear));
            } else if (order.Discriminator == "Part")
            {
                order.Product = Mapper.Map<ProductAIO>(this.PartService.GetById(order.ProductId, IncludeAll.Part));
            }
        }

        private void enrichOrder(OrderHeader order)
        {
            foreach (var orderDetail in order.OrderDetails)
            {
                enrichOrderDetail(orderDetail);
            }
        }

        public OrderHeader Cart(int customerId)
        {
            var item = Mapper.Map<OrderHeader>(GetDraftOrderForCustomer(customerId));

            enrichOrder(item);
            
            return item;
        }
        
        public OrderHeader GetDetailsForCustomer(int id)
        {
            var itemDB = Context.OrderHeaders
                .Include(element => element.ShippingInfo)
                .Include(element => element.OrderDetails)
                .ThenInclude(od => od.Product)
                .FirstOrDefault(x => x.Id == id);

            if (itemDB == null)
            {
                return null;
            }
            
            var item = Mapper.Map<OrderHeader>(itemDB);

            enrichOrder(item);
            
            return item;
        }

        public OrderHeader ProcessCustomer(int customerId, OrderRequest request)
        {
            var order = GetDraftOrderForCustomer(customerId);

            var payment = new PaymentInsertRequest()
            {
                Method = "PayPal"
            };
            
            var state = BaseState.CreateState((OrderState)order.Status);
            state.CurrentEntity = order;

            if (!state.Process(payment, request.ShippingInfo))
            {
                throw new HttpRequestException("");
            }
            
            Context.SaveChanges();

            return Mapper.Map<OrderHeader>(order);
        }

        public OrderDetail RemoveCartItem(int customerId, int itemId)
        {
            var item = Context.OrderDetail
                .Include(item => item.Order)
                .FirstOrDefault(item => item.Id == itemId);

            if (item == null)
            {
                throw new KeyNotFoundException("Order detail was not found");
            }

            if (item.Order.CustomerId != customerId)
            {
                throw new UnauthorizedAccessException("Unauthorized");
            }

            Context.OrderDetail.Remove(item);
            Context.SaveChanges();
            return Mapper.Map<OrderDetail>(item);
        }

        public override OrderHeader Update(int id, OrderHeaderUpdateRequest update)
        {
            var item = Context.OrderHeaders.Find(id);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }


            var state = BaseState.CreateState((OrderState)item.Status);
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

            var state = BaseState.CreateState((OrderState)item.Status);
            state.CurrentEntity = item;

            return state.Process(req, null);
        }

        public override IQueryable<Data.OrderHeader> AddInclude(IQueryable<Data.OrderHeader> query, OrderSearchObject search = null)
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

        public override IQueryable<Data.OrderHeader> AddFilter(IQueryable<Data.OrderHeader> query, OrderSearchObject search = null)
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

            if (search?.ExcludeStates != null && search.ExcludeStates.Count != 0)
            {
                filteredQuery = filteredQuery.Where(x => search.ExcludeStates.Count(y => x.Status != y) == 0);
            }

            return filteredQuery;
        }
        public OrderHeader GetDetails(int id)
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
                    (detail as OrderDetailBicycle).BicycleSize = Context.BicycleSizes.Find((detail as OrderDetailBicycle).BicycleSizeId);
                }
            }

            return Mapper.Map<OrderHeader>(entity);
        }
        
        

        public OrderDetail UpdateDetail(int id, OrderDetailsUpdateRequest req)
        {
            var detail = Context.OrderDetail.Find(id);

            if (detail == null)
            {
                throw new Exception("Order Detail Not Found");
            }

            var order = Context.OrderHeaders.Find(detail.OrderId);

            var state = BaseState.CreateState((OrderState)order.Status);
            state.CurrentEntity = order;

            return state.UpdateOrderDetail(id, req);
        }

        public OrderDetail DeleteDetail(int id)
        {
            var detail = Context.OrderDetail.Find(id);

            if (detail == null)
            {
                throw new Exception("Order Detail Not Found");
            }


            var order = Context.OrderHeaders.Find(detail.OrderId);

            var state = BaseState.CreateState((OrderState)order.Status);
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

            var state = BaseState.CreateState((OrderState)order.Status);
            state.CurrentEntity = order;

            return state.DeleteShippingInfo();
        }

        public OrderHeader Delete(int id)
        {
            var item = Context.OrderHeaders.Find(id);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((OrderState)item.Status);
            state.CurrentEntity = item;

            return state.Delete();
        }


        public OrderHeader Cancel(int id)
        {
            var item = Context.OrderHeaders.Include(q => q.OrderDetails).ThenInclude(q => q.Product).Where(x => x.Id == id).First();

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((OrderState)item.Status);
            state.CurrentEntity = item;

            return state.Cancel();
        }


        public OrderHeader Pack(int id)
        {
            var item = Context.OrderHeaders.Find(id);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((OrderState)item.Status);
            state.CurrentEntity = item;

            state.Pack();

            return Mapper.Map<OrderHeader>(item);

        }

        public OrderHeader Ship(int id)
        {
            var item = Context.OrderHeaders.Find(id);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((OrderState)item.Status);
            state.CurrentEntity = item;

            state.Ship();

            return Mapper.Map<OrderHeader>(item);
        }

        public OrderHeader Deliver(int id)
        {
            var item = Context.OrderHeaders.Find(id);

            if (item == null)
            {
                throw new Exception("Order Not Found");
            }

            var state = BaseState.CreateState((OrderState)item.Status);
            state.CurrentEntity = item;

            state.Deliver();

            return Mapper.Map<OrderHeader>(item);
        }
    }
}
