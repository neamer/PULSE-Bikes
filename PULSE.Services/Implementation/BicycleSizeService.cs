using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Services.Implementation
{
    public class BicycleSizeService : BaseCRUDService<Model.BicycleSize, Data.BicycleSize, NameGenericSearchObject, BicycleSizeUpsertRequest, BicycleSizeUpsertRequest>, IBicycleSizeService
    {
        public BicycleSizeService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
