using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Interfaces
{
    public interface IServicingService
    {
        public Servicing RegisterServicing(RegisterServicingRequest req);
        public Servicing GetDetails(int id);
        public IEnumerable<Servicing> Get(ServicingSearchObject search);
        public Servicing Complete(int id);
        public Servicing Cancel(int id);
        public Servicing SubmitOFfer(int id, ServicingOfferInsertRequest req);
        public Servicing Update(int id, ServicingUpdateRequest req);
        public Servicing RegisterAcceptedOffer(int id, PaymentInsertRequest req);
        public Servicing GetDetailsForCustomer(int id);
    }
}
