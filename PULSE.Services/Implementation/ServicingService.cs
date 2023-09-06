using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;
using PULSE.Services.StateMachines.Servicings;

namespace PULSE.Services.Implementation
{
    public class ServicingService : IServicingService
    {
        public PULSEContext Context { get; set; }
        public IMapper Mapper { get; set; }
        public BaseState BaseState;

        public ServicingService(PULSEContext context, IMapper mapper, BaseState baseState)
        {
            Context = context;
            Mapper = mapper;
            BaseState = baseState;

        }
        public Model.Servicing RegisterServicing(RegisterServicingRequest req)
        {
            var state = BaseState.CreateState(Model.ServicingState.Initial);

            return state.RegisterServicing(req);
        }

        public Model.Servicing SubmitOFfer(int id, ServicingOfferInsertRequest req)
        {
            var item = Context.Servicings.Find(id);

            if(item == null)
            {
                throw new Exception("Not Found");
            }

            var state = BaseState.CreateState((ServicingState)item.Status);
            state.CurrentEntity = item;

            return state.SubmitOffer(req);
        }

        public Model.Servicing GetDetails(int id)
        {
            var item = Context.Servicings.Include(q => q.Customer).Include(q => q.Payment)
                .Include(q => q.ServicingParts).ThenInclude(q => q.Product).Where(q => q.Id == id).First();

            if (item == null)
            {
                throw new Exception("Not Found");
            }

            return Mapper.Map<Model.Servicing>(item);
        }

        public Model.Servicing RegisterAcceptedOffer(int id, PaymentInsertRequest req)
        {
            var item = Context.Servicings.Include(q => q.ServicingParts).ThenInclude(q => q.Product).Where(q => q.Id == id).First();

            if (item == null)
            {
                throw new Exception("Not Found");
            }

            var state = BaseState.CreateState((ServicingState)item.Status);
            state.CurrentEntity = item;

            return state.RegisterAcceptedOffer(req);
        }

        public Model.Servicing Complete(int id)
        {
            var item = Context.Servicings.Include(q => q.ServicingParts).ThenInclude(q => q.Product).Where(q => q.Id == id).First();

            if (item == null)
            {
                throw new Exception("Not Found");
            }

            var state = BaseState.CreateState((ServicingState)item.Status);
            state.CurrentEntity = item;

            return state.Completed();
        }

        public IEnumerable<Model.Servicing> Get(ServicingSearchObject search)
        {
            var query = Context.Set<Data.Servicing>().AsQueryable();

            if (search?.IncludeParts == true)
            {
                query = query.Include(q => q.ServicingParts);
            }

            if (search?.IncludePayment == true)
            {
                query = query.Include(q => q.Payment);
            }

            if (search?.IncludeCustomer == true)
            {
                query = query.Include(q => q.Customer);
            }

            if (!string.IsNullOrWhiteSpace(search?.AnyField))
            {
                query = query.Where(x => x.ServicingNumber.ToLower().Contains(search.AnyField.ToLower()));
            }

            if (search?.Status != null)
            {
                query = query.Where(x => x.Status == search.Status);
            }


            var entity = query.AsQueryable();

            if (search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                entity = entity.Take(search.PageSize.Value).Skip(search.Page.Value * search.PageSize.Value);
            }

            var list = entity.ToList();
            return Mapper.Map<IList<Model.Servicing>>(list);
        }

        public Model.Servicing Update(int id, ServicingUpdateRequest req)
        {
            var item = Context.Servicings.Find(id);

            if (item == null)
            {
                throw new Exception("Not Found");
            }

            var state = BaseState.CreateState((ServicingState)item.Status);
            state.CurrentEntity = item;

            return state.Update(req);
        }

        public Model.Servicing Cancel(int id)
        {
            var item = Context.Servicings.Find(id);

            if (item == null)
            {
                throw new Exception("Not Found");
            }

            var state = BaseState.CreateState((ServicingState)item.Status);
            state.CurrentEntity = item;

            return state.Cancel();
        }
    }
}
