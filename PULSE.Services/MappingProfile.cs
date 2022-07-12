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

            CreateMap<Database.Brand, Model.Brand>();
            CreateMap<BrandUpsertRequest, Database.Brand>();

            CreateMap<Database.Part,ProductUpsertRequest>();
            CreateMap<PartUpsertRequest, Database.Product>();
            CreateMap<PartUpsertRequest, Database.Part>();
            CreateMap<Database.Part, Model.Part>()
                .ForMember(model => model.BrandId, o => o.MapFrom(db => db.Product.BrandId))
                .ForMember(model => model.Brand, o => o.MapFrom(db => db.Product.Brand))
                .ForMember(model => model.ProductNumber, o => o.MapFrom(db => db.Product.ProductNumber))
                .ForMember(model => model.Model, o => o.MapFrom(db => db.Product.Model))
                .ForMember(model => model.Description, o => o.MapFrom(db => db.Product.Description))
                .ForMember(model => model.Price, o => o.MapFrom(db => db.Product.Price))
                .ForMember(model => model.CreatedAt, o => o.MapFrom(db => db.Product.CreatedAt))
                .ForMember(model => model.UpdatedAt, o => o.MapFrom(db => db.Product.UpdatedAt))
                .ForMember(model => model.ThumbImage, o => o.MapFrom(db => db.Product.ThumbImage));
        }
    }
}
