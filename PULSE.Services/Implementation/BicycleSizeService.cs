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
    public class BicycleSizeService : BaseCRUDService<Model.BicycleSize, Database.BicycleSize, NameGenericSearchObject, BicycleSizeUpsertRequest, BicycleSizeUpsertRequest>, IBicycleSizeService
    {
        public BicycleSizeService(PULSEContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
