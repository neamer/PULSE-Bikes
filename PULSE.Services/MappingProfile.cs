using AutoMapper;
using PULSE.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.staff, Model.Staff>();

            CreateMap<Database.Role, Model.Role>();

            CreateMap<StaffInsertRequest, Database.staff>();
            CreateMap<StaffUpdateRequest, Database.staff>();
        }
    }
}
