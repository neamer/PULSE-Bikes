using Microsoft.EntityFrameworkCore;
using PULSE.Services.Implementation;
using PULSE.Services.Interfaces;
using PULSE.Services;
using PULSE;
using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "basic"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
            },
            new string[]{}
        }
    });
});

builder.Services.AddTransient<IStaffService, StaffService>();

builder.Services.AddTransient<IProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.PartCategory>, ProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.PartCategory>>();
builder.Services.AddTransient<IProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.GearCategory>, ProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.GearCategory>>();
builder.Services.AddTransient<IProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.BicycleCategory>, ProductCategoryService<PULSE.Model.ProductCategory, PULSE.Services.Database.BicycleCategory>>();

builder.Services.AddTransient<IBrandService, BrandService>();

builder.Services.AddTransient<IPartService, PartService>();
builder.Services.AddTransient<IGearService, GearService>();
builder.Services.AddTransient<IBicycleService, BicycleService>();

builder.Services.AddAutoMapper(typeof(IStaffService));

builder.Services.AddAuthentication("BasicAuthentication")
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
