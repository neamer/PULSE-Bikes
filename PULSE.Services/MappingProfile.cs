using AutoMapper;
using PULSE.Model.Requests;
using PULSE.Services.Data;

namespace PULSE.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<string, byte[]>().ConvertUsing(s => System.Convert.FromBase64String(s));
            CreateMap<byte[], string>().ConvertUsing(bytes => System.Convert.ToBase64String(bytes));
            
            CreateMap<Data.staff, Model.Staff>();
            CreateMap<StaffInsertRequest, Data.staff>();
            CreateMap<StaffUpdateRequest, Data.staff>();
            CreateMap<Data.Role, Model.Role>();

            CreateMap<Data.ShippingInfo, Model.ShippingInfo>();
            CreateMap<Model.ShippingInfo, Data.ShippingInfo>();

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
            CreateMap<AvailableSizeInsertRequest, Data.AvailableSize>();
            CreateMap<AvailableSizeUpdateRequest, Data.AvailableSize>();

            CreateMap<Data.Bicycle, Model.ProductAIO>();
            CreateMap<Data.Part, Model.ProductAIO>();
            CreateMap<Data.Gear, Model.ProductAIO>();
            
            CreateMap<Model.Bicycle, Model.ProductAIO>();
            CreateMap<Model.Part, Model.ProductAIO>();
            CreateMap<Model.Gear, Model.ProductAIO>();

            #endregion

            #region OrderSection
            
            CreateMap<OrderDetailsInsertRequest, Data.OrderDetailPart>();
            CreateMap<OrderDetailsInsertRequest, Data.OrderDetailGear>();
            CreateMap<OrderDetailsInsertRequest, Data.OrderDetailBicycle>();
            CreateMap<OrderDetailBicycleInsertRequest, Data.OrderDetailBicycle>();
            CreateMap<OrderDetailsAIOInsertRequest, Data.OrderDetail>()
                .Include<OrderDetailsAIOInsertRequest, Data.OrderDetailBicycle>()
                .Include<OrderDetailsAIOInsertRequest, Data.OrderDetailGear>()
                .Include<OrderDetailsAIOInsertRequest, Data.OrderDetailPart>()
                .ConstructUsing((src, context) =>
                {
                    return src.Discriminator switch
                    {
                        "Bicycle" => context.Mapper.Map<OrderDetailBicycle>(src),
                        "Gear" => context.Mapper.Map<OrderDetailGear>(src),
                        "Part" => context.Mapper.Map<OrderDetailPart>(src),
                        _ => throw new Exception("Missing discriminator from order detail")
                    };
                });
            CreateMap<OrderDetailsAIOInsertRequest, Data.OrderDetailBicycle>();
            CreateMap<OrderDetailsAIOInsertRequest, Data.OrderDetailGear>();
            CreateMap<OrderDetailsAIOInsertRequest, Data.OrderDetailPart>();
            
            CreateMap<OrderDetailsUpdateRequest, Data.OrderDetail>();

            CreateMap<Data.OrderHeader, Model.OrderHeader>()
                .ForMember(x => x.ShippingConst, opt => opt.MapFrom(x => x.ShippingConst));
            CreateMap<OrderHeaderInsertRequest, Data.OrderHeader>();
            CreateMap<OrderHeaderUpdateRequest, Data.OrderHeader>();
            CreateMap<Data.OrderDetailPart, Model.OrderDetail>();
            CreateMap<Data.OrderDetailGear, Model.OrderDetail>();
            CreateMap<Data.OrderDetailBicycle, Model.OrderDetail>();
            CreateMap<Data.OrderDetailAIO, Model.OrderDetail>();
            CreateMap<Data.OrderDetail, Model.OrderDetail>();

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
