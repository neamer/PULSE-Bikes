using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services.Interfaces
{
    public interface IShippingInfoService : ICRUDService<Model.ShippingInfo, BaseSearchObject, ShippingInfoUpsertRequest, ShippingInfoUpsertRequest>
    {
    }
}
