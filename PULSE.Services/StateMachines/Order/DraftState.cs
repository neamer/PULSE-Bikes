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
    public class DraftState : BaseState
    {
        public DraftState(IServiceProvider serviceProvider, PULSEContext context, IMapper mapper)
            : base(serviceProvider, context, mapper)
        {
        }

        public override Model.OrderHeader Update(OrderHeaderUpdateRequest request)
        {
            if (CurrentEntity != null)
            {
                Mapper.Map(request, CurrentEntity);
            }
            else
            {
                return null;
            }

            Context.SaveChanges();

            return Mapper.Map<Model.OrderHeader>(CurrentEntity);
        }

        public override void Process(PaymentInsertRequest req)
        {
            var payment = Mapper.Map<Database.Payment>(req);
            payment.TimeOfPayment = DateTime.Now;

            Context.SaveChanges();

            CurrentEntity.Status = (int)States.Processed;
            CurrentEntity.TimeProcessed = DateTime.Now;
            CurrentEntity.PaymentId = payment.PaymentId;

            Context.SaveChanges();
        }

        public override List<string> AllowedActions()
        {
            var list = base.AllowedActions();

            list.Add("Update");
            list.Add("Process");
            list.Add("Cancel");

            return list;
        }
    }
}
