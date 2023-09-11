using AutoMapper;
using PULSE.Model.Requests;

namespace PULSE.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.staff, Model.Staff>();
            CreateMap<StaffInsertRequest, Data.staff>();
            CreateMap<StaffUpdateRequest, Data.staff>();
            CreateMap<Data.Role, Model.Role>();

            #region ProductSection

            CreateMap<Data.PartCategory, Model.ProductCategory>();
            CreateMap<ProductCategoryUpsertRequest, Data.PartCategory>();
            CreateMap<Data.GearCategory, Model.ProductCategory>();
            CreateMap<ProductCategoryUpsertRequest, Data.GearCategory>();
            CreateMap<Data.BicycleCategory, Model.ProductCategory>();
            CreateMap<ProductCategoryUpsertRequest, Data.BicycleCategory>();

            CreateMap<Data.ProductImage, Model.ProductImage>();
            CreateMap<ProductImageUpsertRequest, Data.ProductImage>();

            CreateMap<Data.Brand, Model.Brand>();
            CreateMap<BrandUpsertRequest, Data.Brand>();

            CreateMap<Data.Part, ProductUpsertRequest>();
            CreateMap<PartUpsertRequest, Data.Part>();
            CreateMap<Data.Part, Model.Part>();

            CreateMap<Data.Gear, ProductUpsertRequest>();
            CreateMap<GearUpsertRequest, Data.Gear>();
            CreateMap<Data.Gear, Model.Gear>();
            
            CreateMap<Data.Bicycle, ProductUpsertRequest>();
            CreateMap<BicycleUpsertRequest, Data.Bicycle>();
            CreateMap<Data.Bicycle, Model.Bicycle>();

            CreateMap<Data.BicycleSize, Model.BicycleSize>();
            CreateMap<BicycleSizeUpsertRequest, Data.BicycleSize>();

            CreateMap<Data.AvailableSize, Model.AvailableSize>();
            CreateMap<AvailableSizeUpsertRequest, Data.AvailableSize>();

            CreateMap<Data.Bicycle, Model.ProductAIO>();
            CreateMap<Data.Part, Model.ProductAIO>();
            CreateMap<Data.Gear, Model.ProductAIO>();

            #endregion

            #region OrderSection

            CreateMap<Data.OrderHeader, Model.OrderHeader>();
            CreateMap<OrderHeaderInsertRequest, Data.OrderHeader>();
            CreateMap<OrderHeaderUpdateRequest, Data.OrderHeader>();
            CreateMap<Data.OrderDetailPart, Model.OrderDetail>();
            CreateMap<Data.OrderDetailGear, Model.OrderDetail>();
            CreateMap<Data.OrderDetailBicycle, Model.OrderDetail>();
            CreateMap<Data.OrderDetailAIO, Model.OrderDetail>();

            CreateMap<OrderDetailsInsertRequest, Data.OrderDetailPart>();
            CreateMap<OrderDetailsInsertRequest, Data.OrderDetailGear>();
            CreateMap<OrderDetailsInsertRequest, Data.OrderDetailBicycle>();
            CreateMap<OrderDetailBicycleInsertRequest, Data.OrderDetailBicycle>();
            CreateMap<OrderDetailsAIOInsertRequest, Data.OrderDetail>();
            CreateMap<OrderDetailsUpdateRequest, Data.OrderDetail>();

            CreateMap<Data.Payment, Model.Payment>();
            CreateMap<PaymentInsertRequest, Data.Payment>();

            CreateMap<Data.ShippingInfo, Model.ShippingInfo>();
            CreateMap<ShippingInfoUpsertRequest, Data.ShippingInfo>();

            CreateMap<Data.Customer, Model.Customer>();
            CreateMap<CustomerInsertRequest, Data.Customer>();
            CreateMap<CustomerUpdateRequest, Data.Customer>();

            #endregion

            CreateMap<Data.Servicing, Model.Servicing>();
            CreateMap<Data.ServicingPart, Model.ServicingPart>();
            CreateMap<RegisterServicingRequest, Data.Servicing>();

            CreateMap<ServicingOfferInsertRequest, Data.Servicing>()
                .ForMember(x => x.ServicingParts, opt => opt.Ignore());
            CreateMap<ServicingPartBatchInsertRequest, Data.ServicingPart>();
            CreateMap<ServicingPartInsertRequest, Data.ServicingPart>();
            CreateMap<ServicingUpdateRequest, Data.Servicing>();
        }
    }
}
