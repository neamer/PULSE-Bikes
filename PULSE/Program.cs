using Microsoft.EntityFrameworkCore;
using PULSE.Services.Implementation;
using PULSE.Services.Interfaces;
using PULSE.Services;
using PULSE;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IStaffService, StaffService>();

builder.Services.AddTransient<IProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.PartCategory>, ProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.PartCategory>>();
builder.Services.AddTransient<IProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.GearCategory>, ProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.GearCategory>>();
builder.Services.AddTransient<IProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.BicycleCategory>, ProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.BicycleCategory>>();

builder.Services.AddTransient<IBrandService, BrandService>();

builder.Services.AddTransient<IPartService, PartService>();
builder.Services.AddTransient<IGearService, GearService>();
builder.Services.AddTransient<IBicycleService, BicycleService>();

builder.Services.AddAutoMapper(typeof(IStaffService));

builder.Services.AddDbContext<PULSE.Services.Database.PULSEContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
