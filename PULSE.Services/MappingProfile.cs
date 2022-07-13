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

            CreateMap<Database.PartCategory, Model.ProductCategory>();
            CreateMap<ProductCategoryUpsertRequest, Database.PartCategory>();
            CreateMap<Database.GearCategory, Model.ProductCategory>();
            CreateMap<ProductCategoryUpsertRequest, Database.GearCategory>();
            CreateMap<Database.BicycleCategory, Model.ProductCategory>();
            CreateMap<ProductCategoryUpsertRequest, Database.BicycleCategory>();

            CreateMap<Database.Brand, Model.Brand>();
            CreateMap<BrandUpsertRequest, Database.Brand>();

            CreateMap<Database.Part, ProductUpsertRequest>();
            CreateMap<PartUpsertRequest, Database.Part>();
            CreateMap<Database.Part, Model.Part>();

            CreateMap<Database.Gear, ProductUpsertRequest>();
            CreateMap<GearUpsertRequest, Database.Gear>();
            CreateMap<Database.Gear, Model.Gear>();
            
            CreateMap<Database.Bicycle, ProductUpsertRequest>();
            CreateMap<BicycleUpsertRequest, Database.Bicycle>();
            CreateMap<Database.Bicycle, Model.Bicycle>();
        }
    }
}
