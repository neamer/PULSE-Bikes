using PULSE.Services.Implementation;
using PULSE.Services.Interfaces;

namespace PULSE.Helpers
{
    public class Setup
    {
        public static void RegisterStates(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<Services.StateMachines.Order.BaseState>();
            builder.Services.AddTransient<Services.StateMachines.Order.InitialState>();
            builder.Services.AddTransient<Services.StateMachines.Order.DraftState>();
            builder.Services.AddTransient<Services.StateMachines.Order.ProcessedState>();
            builder.Services.AddTransient<Services.StateMachines.Order.PackedState>();
            builder.Services.AddTransient<Services.StateMachines.Order.ShippedState>();
            builder.Services.AddTransient<Services.StateMachines.Order.DeliveredState>();
            builder.Services.AddTransient<Services.StateMachines.Order.CancelledState>();

            builder.Services.AddTransient<Services.StateMachines.Servicings.BaseState>();
            builder.Services.AddTransient<Services.StateMachines.Servicings.InitialState>();
            builder.Services.AddTransient<Services.StateMachines.Servicings.PendingReview>();
            builder.Services.AddTransient<Services.StateMachines.Servicings.PendingPayment>();
            builder.Services.AddTransient<Services.StateMachines.Servicings.PendingServicing>();
            builder.Services.AddTransient<Services.StateMachines.Servicings.Cancelled>();
        }

        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IStaffService, StaffService>();

            builder.Services.AddTransient<IProductCategoryService<Model.ProductCategory, Services.Data.PartCategory>, ProductCategoryService<Model.ProductCategory, Services.Data.PartCategory>>();
            builder.Services.AddTransient<IProductCategoryService<Model.ProductCategory, Services.Data.GearCategory>, ProductCategoryService<Model.ProductCategory, Services.Data.GearCategory>>();
            builder.Services.AddTransient<IProductCategoryService<Model.ProductCategory, Services.Data.BicycleCategory>, ProductCategoryService<Model.ProductCategory, Services.Data.BicycleCategory>>();

            builder.Services.AddTransient<IBrandService, BrandService>();

            builder.Services.AddTransient<IPartService, PartService>();
            builder.Services.AddTransient<IGearService, GearService>();
            builder.Services.AddTransient<IBicycleService, BicycleService>();

            builder.Services.AddTransient<IBicycleSizeService, BicycleSizeService>();
            builder.Services.AddTransient<IAvailableSizeService, AvailableSizeService>();

            builder.Services.AddTransient<IOrderService, OrderService>();
            builder.Services.AddTransient<IOrderDetailPartService, OrderDetailPartService>();
            builder.Services.AddTransient<IOrderDetailGearService, OrderDetailGearService>();
            builder.Services.AddTransient<IOrderDetailBicycleService, OrderDetailBicycleService>();

            builder.Services.AddTransient<IShippingInfoService, ShippingInfoService>();
            builder.Services.AddTransient<ICustomerService, CustomerService>();

            builder.Services.AddTransient<IServicingService, ServicingService>();
        }
    }
}
