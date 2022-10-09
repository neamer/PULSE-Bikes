using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Database;
using PULSE.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Implementation
{
    public class ShippingInfoService : BaseCRUDService<Model.ShippingInfo, Database.ShippingInfo, BaseSearchObject, ShippingInfoUpsertRequest, ShippingInfoUpsertRequest>, IShippingInfoService
    {
        public ShippingInfoService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
