using AutoMapper;
using PULSE.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PULSE.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.staff, Model.Staff>();
            CreateMap<StaffInsertRequest, Database.staff>();
            CreateMap<StaffUpdateRequest, Database.staff>();
            CreateMap<Database.Role, Model.Role>();

            CreateMap<Database.PartCategory, Model.ProductCategory>()
                .ForMember(model => model.ID , o => o.MapFrom(db => db.PartCategoryId));
            CreateMap<ProductCategoryUpsertRequest, Database.PartCategory>();
            CreateMap<Database.GearCategory, Model.ProductCategory>()
                .ForMember(model => model.ID, o => o.MapFrom(db => db.GearCategoryId));
            CreateMap<ProductCategoryUpsertRequest, Database.GearCategory>();
            CreateMap<Database.BicycleType, Model.ProductCategory>()
                .ForMember(model => model.ID, o => o.MapFrom(db => db.BicycleTypeId));
            CreateMap<ProductCategoryUpsertRequest, Database.BicycleType>();
        }
    }
}
