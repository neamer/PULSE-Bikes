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

            #region ProductSection

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

            CreateMap<Database.BicycleSize, Model.BicycleSize>();
            CreateMap<BicycleSizeUpsertRequest, Database.BicycleSize>();

            CreateMap<Database.AvailableSize, Model.AvailableSize>();
            CreateMap<AvailableSizeUpsertRequest, Database.AvailableSize>();

            CreateMap<Database.Bicycle, Model.ProductAIO>();
            CreateMap<Database.Part, Model.ProductAIO>();
            CreateMap<Database.Gear, Model.ProductAIO>();

            #endregion

            #region OrderSection

            CreateMap<Database.OrderHeader, Model.OrderHeader>();
            CreateMap<OrderHeaderInsertRequest, Database.OrderHeader>();
            CreateMap<OrderHeaderUpdateRequest, Database.OrderHeader>();
            CreateMap<Database.OrderDetailPart, Model.OrderDetail>();
            CreateMap<Database.OrderDetailGear, Model.OrderDetail>();
            CreateMap<Database.OrderDetailBicycle, Model.OrderDetail>();
            CreateMap<Database.OrderDetailAIO, Model.OrderDetail>();

            CreateMap<OrderDetailsInsertRequest, Database.OrderDetailPart>();
            CreateMap<OrderDetailsInsertRequest, Database.OrderDetailGear>();
            CreateMap<OrderDetailsInsertRequest, Database.OrderDetailBicycle>();
            CreateMap<OrderDetailBicycleInsertRequest, Database.OrderDetailBicycle>();
            CreateMap<OrderDetailsAIOInsertRequest, Database.OrderDetail>();
            CreateMap<OrderDetailsUpdateRequest, Database.OrderDetail>();

            CreateMap<Database.Payment, Model.Payment>();
            CreateMap<PaymentInsertRequest, Database.Payment>();

            CreateMap<Database.ShippingInfo, Model.ShippingInfo>();
            CreateMap<ShippingInfoUpsertRequest, Database.ShippingInfo>();

            CreateMap<Database.Customer, Model.Customer>();
            CreateMap<CustomerInsertRequest, Database.Customer>();
            CreateMap<CustomerUpdateRequest, Database.Customer>();

            #endregion

            CreateMap<Database.Servicing, Model.Servicing>();
            CreateMap<Database.ServicingPart, Model.ServicingPart>();
            CreateMap<RegisterServicingRequest, Database.Servicing>();

            CreateMap<ServicingOfferInsertRequest, Database.Servicing>()
                .ForMember(x => x.ServicingParts, opt => opt.Ignore());
            CreateMap<ServicingPartBatchInsertRequest, Database.ServicingPart>();
            CreateMap<ServicingPartInsertRequest, Database.ServicingPart>();
            CreateMap<ServicingUpdateRequest, Database.Servicing>();
        }
    }
}
