using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Services.Implementation
{
    public class ShippingInfoService : BaseCRUDService<Model.ShippingInfo, Data.ShippingInfo, BaseSearchObject, ShippingInfoUpsertRequest, ShippingInfoUpsertRequest>, IShippingInfoService
    {
        public ShippingInfoService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
