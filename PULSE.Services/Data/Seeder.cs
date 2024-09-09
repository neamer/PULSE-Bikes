using Microsoft.EntityFrameworkCore;
namespace PULSE.Services.Data
{
    partial class PULSEContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Role>().HasData
            (
                new Role() { Id = 1, Name = "Administrator" },
                new Role() { Id = 2, Name = "Mechanic" },
                new Role() { Id = 3, Name = "Storekeeper" },
                new Role() { Id = 4, Name = "Salesperson" }
            );

            modelBuilder.Entity<staff>().HasData
            (
                new staff()
                {
                    Id = 1,
                    RoleId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Username = "jdoe",
                    Email = "jdoe@example.com",
                    PasswordHash = "VXbqh5tz66lkaFI8gwiRyB29qbE=",
                    PasswordSalt = "LijOFjQrJ2ySPafDaJV89g==",
                    Status = true,
                    PhoneNumber = "+111/222-3334",
                    DateOfBirth = DateTime.Parse("1990-08-25"),
                    DateOfEmployment = DateTime.Parse("2022-08-25"),
                    CreatedAt = DateTime.Parse("2022-08-25 14:58:56.843"),
                    UpdatedAt = DateTime.Parse("2022-08-25 14:58:56.843")
                },
                new staff()
                {
                    Id = 2,
                    RoleId = 2,
                    FirstName = "Frank",
                    LastName = "Thompson",
                    Username = "fthompson",
                    Email = "fthompson@example.com",
                    PasswordHash = "oRG/dpG4SrYERbbmWle2IHbZoyc=",
                    PasswordSalt = "8RclDZ3hTHXlWerCumSTNg==",
                    Status = true,
                    PhoneNumber = "+111/222-3334",
                    DateOfBirth = DateTime.Parse("1990-08-25"),
                    DateOfEmployment = DateTime.Parse("2022-08-25"),
                    CreatedAt = DateTime.Parse("2022-08-25 14:58:56.843"),
                    UpdatedAt = DateTime.Parse("2022-08-25 14:58:56.843")
                },
                new staff()
                {
                    Id = 3,
                    RoleId = 3,
                    FirstName = "Mark",
                    LastName = "Henry",
                    Username = "mhenry",
                    Email = "mhenry@example.com",
                    PasswordHash = "4chVLh8LhushFpJHkrMLTppXSwE=",
                    PasswordSalt = "lKQAgzpznhbp136CMQzZrw==",
                    Status = true,
                    PhoneNumber = "+111/222-3334",
                    DateOfBirth = DateTime.Parse("1990-08-25"),
                    DateOfEmployment = DateTime.Parse("2022-08-25"),
                    CreatedAt = DateTime.Parse("2022-08-25 14:58:56.843"),
                    UpdatedAt = DateTime.Parse("2022-08-25 14:58:56.843")
                },
                new staff()
                {
                    Id = 4,
                    RoleId = 4,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Username = "janed",
                    Email = "janed@example.com",
                    PasswordHash = "76786KICD2CmHC06juN+BvqeHQg=",
                    PasswordSalt = "VFgOG9JbipvRqaul/+HqBg==",
                    Status = true,
                    PhoneNumber = "+111/222-3334",
                    DateOfBirth = DateTime.Parse("1990-08-25"),
                    DateOfEmployment = DateTime.Parse("2022-08-25"),
                    CreatedAt = DateTime.Parse("2022-08-25 14:58:56.843"),
                    UpdatedAt = DateTime.Parse("2022-08-25 14:58:56.843")
                }
            );

            modelBuilder.Entity<Customer>().HasData
           (
               new Customer()
               {
                   Id = 1,
                   FirstName = "Dwayne",
                   LastName = "Johnson",
                   Username = "djohnson",
                   Email = "djohnson@example.com",
                   PasswordHash = "MmGFoK5IT9yQmXu567Yh6ALLvbc=",
                   PasswordSalt = "0fut3gMif6mwIMaOBzUGYQ==",
                   Status = true,
                   PhoneNumber = "+111/222-3334",
                   CreatedAt = DateTime.Parse("2022-08-25 14:58:56.843"),
                   UpdatedAt = DateTime.Parse("2022-08-25 14:58:56.843")
               }
            );

           modelBuilder.Entity<Brand>().HasData
            (
                new Brand() { Id = 1, Name = "TREK" },
                new Brand() { Id = 2, Name = "CUBE" },
                new Brand() { Id = 3, Name = "GIANT" },
                new Brand() { Id = 4, Name = "MERIDA" },
                new Brand() { Id = 5, Name = "SCOTT" }
            );

            modelBuilder.Entity<BicycleCategory>().HasData
            (
                new BicycleCategory() { Id = 5, Name = "MTB" },
                new BicycleCategory() { Id = 6, Name = "Road Bike" },
                new BicycleCategory() { Id = 7, Name = "Gravel Bike" },
                new BicycleCategory() { Id = 20, Name = "Kids Bike" }
            );

            modelBuilder.Entity<PartCategory>().HasData
            (
                new PartCategory() { Id = 1, Name = "Wheel" },
                new PartCategory() { Id = 2, Name = "Tire" },
                new PartCategory() { Id = 16, Name = "Seat" },
                new PartCategory() { Id = 17, Name = "Rear Derailleur" },
                new PartCategory() { Id = 18, Name = "V-Brake" },
                new PartCategory() { Id = 19, Name = "Disk Brake" }
            );

            modelBuilder.Entity<GearCategory>().HasData
            (
                new GearCategory() { Id = 3, Name = "Bottle" },
                new GearCategory() { Id = 4, Name = "Bottle Carrier" },
                new GearCategory() { Id = 8, Name = "Carrier" },
                new GearCategory() { Id = 9, Name = "Jacket" },
                new GearCategory() { Id = 10, Name = "Camera 4" },
                new GearCategory() { Id = 11, Name = "Rucksack" },
                new GearCategory() { Id = 12, Name = "Pouch" },
                new GearCategory() { Id = 13, Name = "Illumination" },
                new GearCategory() { Id = 14, Name = "Mudguard" },
                new GearCategory() { Id = 15, Name = "Basket" }
            );

            modelBuilder.Entity<BicycleSize>().HasData
            (
                new BicycleSize() { Id = 1, Size = "M" },
                new BicycleSize() { Id = 2, Size = "S" },
                new BicycleSize() { Id = 3, Size = "L" },
                new BicycleSize() { Id = 4, Size = "XL" }
            );

            modelBuilder.Entity<Bicycle>().HasData
            (
                new Bicycle()
                {
                    Id = 1,
                    BrandId = 1,
                    ProductCategoryId = 6,
                    ProductNumber = "QBXZ-BPZVPK9806",
                    Model = "Killer Zebra",
                    Description = "A high-performance mountain bike designed for rugged terrains with excellent shock absorption and durability.",
                    Price = 364.38m,
                    Discriminator = "Bicycle",
                    ThumbImage = null,
                    Weight = 8.2300m,
                    ProductionYear = 2010,
                    WheelSize = "26",
                    CreatedAt = DateTime.Parse("2021-09-27 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2022-07-19 00:00:00.000")
                },
                new Bicycle()
                {
                    Id = 2,
                    BrandId = 1,
                    ProductCategoryId = 6,
                    ProductNumber = "WJCM-IOXOZG4968",
                    Model = "Nile Crocodile",
                    Description = "A premium road bike with a sleek design, perfect for speed enthusiasts and long-distance riders.",
                    Price = 3201.41m,
                    Discriminator = "Bicycle",
                    ThumbImage = null,
                    Weight = 8.4600m,
                    ProductionYear = 2013,
                    WheelSize = "29",
                    CreatedAt = DateTime.Parse("2022-02-02 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2022-07-19 00:00:00.000")
                },
                new Bicycle()
                {
                    Id = 3,
                    BrandId = 2,
                    ProductCategoryId = 6,
                    ProductNumber = "TDMC-QYYRUC9454",
                    Model = "Plains Zebra",
                    Description = "A versatile hybrid bike suitable for both city commuting and off-road adventures with a comfortable ride.",
                    Price = 2900.49m,
                    Discriminator = "Bicycle",
                    ThumbImage = null,
                    Weight = 9.0800m,
                    ProductionYear = 2012,
                    WheelSize = "29",
                    CreatedAt = DateTime.Parse("2022-02-18 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2022-07-19 00:00:00.000")
                },
                new Bicycle()
                {
                    Id = 4,
                    BrandId = 3,
                    ProductCategoryId = 5,
                    ProductNumber = "LGVC-JWCPLB2398",
                    Model = "Northern Elephant Seal",
                    Description = "A durable and robust mountain bike designed to handle the most challenging trails and rough terrains.",
                    Price = 2693.16m,
                    Discriminator = "Bicycle",
                    ThumbImage = null,
                    Weight = 9.7100m,
                    ProductionYear = 2011,
                    WheelSize = "26",
                    CreatedAt = DateTime.Parse("2021-08-02 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2022-07-19 00:00:00.000")
                },
                new Bicycle()
                {
                    Id = 5,
                    BrandId = 4,
                    ProductCategoryId = 6,
                    ProductNumber = "UGBJ-KSQIJM0190",
                    Model = "Curlew, Black",
                    Description = "A sleek and lightweight bike ideal for city commuting and daily rides, featuring a modern design and efficient performance.",
                    Price = 709.01m,
                    Discriminator = "Bicycle",
                    ThumbImage = null,
                    Weight = 10.0200m,
                    ProductionYear = 2010,
                    WheelSize = "29",
                    CreatedAt = DateTime.Parse("2022-04-30 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2022-07-19 00:00:00.000")
                },
                new Bicycle()
                {
                    Id = 6,
                    BrandId = 4,
                    ProductCategoryId = 6,
                    ProductNumber = "EQKX-QCOLYA9831",
                    Model = "Kookaburra, Laughing",
                    Description = "A high-end road bike with exceptional speed and aerodynamics, designed for competitive cyclists and enthusiasts.",
                    Price = 993.63m,
                    Discriminator = "Bicycle",
                    ThumbImage = null,
                    Weight = 17.0200m,
                    ProductionYear = 2013,
                    WheelSize = "29",
                    CreatedAt = DateTime.Parse("2022-03-19 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2022-07-19 00:00:00.000")
                },
                new Bicycle()
                {
                    Id = 7,
                    BrandId = 5,
                    ProductCategoryId = 6,
                    ProductNumber = "EAOK-QMEEBD8830",
                    Model = "Black-winged Stilt",
                    Description = "A lightweight bike perfect for urban commuting with a stylish frame and efficient gear system.",
                    Price = 473.14m,
                    Discriminator = "Bicycle",
                    ThumbImage = null,
                    Weight = 17.3500m,
                    ProductionYear = 2020,
                    WheelSize = "29",
                    CreatedAt = DateTime.Parse("2022-04-26 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2022-07-19 00:00:00.000")
                },
                new Bicycle()
                {
                    Id = 8,
                    BrandId = 5,
                    ProductCategoryId = 5,
                    ProductNumber = "YYMS-JFQGVN8586",
                    Model = "Pampa Gray Fox",
                    Description = "A robust and reliable bike designed for mixed-terrain riding with excellent suspension and durability.",
                    Price = 2827.99m,
                    Discriminator = "Bicycle",
                    ThumbImage = null,
                    Weight = 5.6400m,
                    ProductionYear = 2022,
                    WheelSize = "29",
                    CreatedAt = DateTime.Parse("2022-06-12 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2022-07-19 00:00:00.000")
                },
                new Bicycle()
                {
                    Id = 9,
                    BrandId = 1,
                    ProductCategoryId = 6,
                    ProductNumber = "ZICU-WPDGRN0328",
                    Model = "Caracara, Yellow",
                    Description = "An all-terrain bike built for adventure seekers, featuring high durability and advanced suspension.",
                    Price = 1401.75m,
                    Discriminator = "Bicycle",
                    ThumbImage = null,
                    Weight = 5.4100m,
                    ProductionYear = 2015,
                    WheelSize = "27.5",
                    CreatedAt = DateTime.Parse("2022-05-23 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2022-07-19 00:00:00.000")
                }
            );


            modelBuilder.Entity<Gear>().HasData
            (
                new Gear()
                {
                    Id = 10,
                    BrandId = 1,
                    ProductCategoryId = 3,
                    ProductNumber = "BTTL-2314ZK",
                    Model = "Cycling Bottle",
                    Description = "Durable and easy-to-clean bottle for hydration during rides.",
                    Price = 8.99m,
                    Discriminator = "Gear",
                    ThumbImage = null,
                    AvailableQty = 150,
                    CreatedAt = DateTime.Parse("2023-01-15 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2023-07-20 00:00:00.000")
                },
                new Gear()
                {
                    Id = 11,
                    BrandId = 1,
                    ProductCategoryId = 4,
                    ProductNumber = "CCAR-7890LP",
                    Model = "Bike Bottle Carrier",
                    Description = "Secure and adjustable bottle carrier for various bike frames.",
                    Price = 16.99m,
                    Discriminator = "Gear",
                    ThumbImage = null,
                    AvailableQty = 80,
                    CreatedAt = DateTime.Parse("2023-02-20 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2023-07-20 00:00:00.000")
                },
                new Gear()
                {
                    Id = 12,
                    BrandId = 1,
                    ProductCategoryId = 4,
                    ProductNumber = "CAM4-5642QS",
                    Model = "Action Camera 4",
                    Description = "High-definition action camera for capturing your adventures on the go.",
                    Price = 149.99m,
                    Discriminator = "Gear",
                    ThumbImage = null,
                    AvailableQty = 45,
                    CreatedAt = DateTime.Parse("2023-03-10 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2023-07-20 00:00:00.000")
                },
                new Gear()
                {
                    Id = 13,
                    BrandId = 2,
                    ProductCategoryId = 4,
                    ProductNumber = "RCKS-2904BN",
                    Model = "Cycling Rucksack",
                    Description = "Spacious and ergonomic rucksack with multiple compartments for all your cycling gear.",
                    Price = 55.99m,
                    Discriminator = "Gear",
                    ThumbImage = null,
                    AvailableQty = 60,
                    CreatedAt = DateTime.Parse("2023-04-25 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2023-07-20 00:00:00.000")
                },
                new Gear()
                {
                    Id = 14,
                    BrandId = 2,
                    ProductCategoryId = 4,
                    ProductNumber = "JCKT-3345GH",
                    Model = "Waterproof Jacket",
                    Description = "High-quality waterproof jacket designed for cycling in any weather.",
                    Price = 89.99m,
                    Discriminator = "Gear",
                    ThumbImage = null,
                    AvailableQty = 70,
                    CreatedAt = DateTime.Parse("2023-05-15 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2023-07-20 00:00:00.000")
                },
                new Gear()
                {
                    Id = 15,
                    BrandId = 2,
                    ProductCategoryId = 4,
                    ProductNumber = "ILUM-4321FD",
                    Model = "Bike Illumination System",
                    Description = "Bright and reliable illumination system to ensure visibility during night rides.",
                    Price = 39.99m,
                    Discriminator = "Gear",
                    ThumbImage = null,
                    AvailableQty = 85,
                    CreatedAt = DateTime.Parse("2023-06-30 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2023-07-20 00:00:00.000")
                }
            );


            modelBuilder.Entity<Part>().HasData
            (
                new Part()
                {
                    Id = 16,
                    BrandId = 1,
                    ProductCategoryId = 5,
                    ProductNumber = "PSXY-1234AB",
                    Model = "Seat e",
                    Description = "Comfortable and ergonomic bike seat for long rides.",
                    Price = 49.99m,
                    Discriminator = "Part",
                    ThumbImage = null,
                    AvailableQty = 150,
                    CreatedAt = DateTime.Parse("2023-07-10 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2023-08-15 00:00:00.000")
                },
                new Part()
                {
                    Id = 17,
                    BrandId = 1,
                    ProductCategoryId = 5,
                    ProductNumber = "RDXY-5678CD",
                    Model = "Rear Derailleur",
                    Description = "Precision rear derailleur for smooth gear shifting.",
                    Price = 89.99m,
                    Discriminator = "Part",
                    ThumbImage = null,
                    AvailableQty = 80,
                    CreatedAt = DateTime.Parse("2023-08-05 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2023-08-15 00:00:00.000")
                },
                new Part()
                {
                    Id = 18,
                    BrandId = 1,
                    ProductCategoryId = 5,
                    ProductNumber = "VBRA-9101EF",
                    Model = "V-Brake",
                    Description = "High-performance V-brake for reliable stopping power.",
                    Price = 29.99m,
                    Discriminator = "Part",
                    ThumbImage = null,
                    AvailableQty = 120,
                    CreatedAt = DateTime.Parse("2023-08-20 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2023-08-25 00:00:00.000")
                },
                new Part()
                {
                    Id = 19,
                    BrandId = 2,
                    ProductCategoryId = 5,
                    ProductNumber = "DBRK-2345GH",
                    Model = "Disk Brake",
                    Description = "Durable disk brake for superior braking performance.",
                    Price = 119.99m,
                    Discriminator = "Part",
                    ThumbImage = null,
                    AvailableQty = 60,
                    CreatedAt = DateTime.Parse("2023-09-01 00:00:00.000"),
                    UpdatedAt = DateTime.Parse("2023-09-10 00:00:00.000")
                }
            );

            modelBuilder.Entity<AvailableSize>().HasData
            (
                new AvailableSize()
                {
                    Id = 1,
                    BicycleSizeId = 1,
                    ProductId = 1,
                    AvailableQty = 10
                },
                new AvailableSize()
                {
                    Id = 2,
                    BicycleSizeId = 2,
                    ProductId = 1,
                    AvailableQty = 5
                },
                new AvailableSize()
                {
                    Id = 3,
                    BicycleSizeId = 3,
                    ProductId = 2,
                    AvailableQty = 8
                },
                new AvailableSize()
                {
                    Id = 4,
                    BicycleSizeId = 4,
                    ProductId = 2,
                    AvailableQty = 7
                },
                new AvailableSize()
                {
                    Id = 5,
                    BicycleSizeId = 1,
                    ProductId = 3,
                    AvailableQty = 12
                },
                new AvailableSize()
                {
                    Id = 6,
                    BicycleSizeId = 3,
                    ProductId = 3,
                    AvailableQty = 8
                },
                new AvailableSize()
                {
                    Id = 7,
                    BicycleSizeId = 4,
                    ProductId = 4,
                    AvailableQty = 6
                },
                new AvailableSize()
                {
                    Id = 8,
                    BicycleSizeId = 1,
                    ProductId = 5,
                    AvailableQty = 14
                },
                new AvailableSize()
                {
                    Id = 9,
                    BicycleSizeId = 2,
                    ProductId = 5,
                    AvailableQty = 11
                },
                new AvailableSize()
                {
                    Id = 10,
                    BicycleSizeId = 3,
                    ProductId = 6,
                    AvailableQty = 9
                },
                new AvailableSize()
                {
                    Id = 11,
                    BicycleSizeId = 4,
                    ProductId = 6,
                    AvailableQty = 5
                },
                new AvailableSize()
                {
                    Id = 12,
                    BicycleSizeId = 1,
                    ProductId = 7,
                    AvailableQty = 10
                },
                new AvailableSize()
                {
                    Id = 13,
                    BicycleSizeId = 2,
                    ProductId = 7,
                    AvailableQty = 8
                },
                new AvailableSize()
                {
                    Id = 14,
                    BicycleSizeId = 3,
                    ProductId = 8,
                    AvailableQty = 6
                },
                new AvailableSize()
                {
                    Id = 15,
                    BicycleSizeId = 4,
                    ProductId = 8,
                    AvailableQty = 4
                },
                new AvailableSize()
                {
                    Id = 16,
                    BicycleSizeId = 1,
                    ProductId = 9,
                    AvailableQty = 8
                }
            );

            modelBuilder.Entity<Payment>().HasData
            (
                new Payment()
                {
                    Id = 1,
                    Method = "PayPal",
                    Amount = 776.18m,
                    TimeOfPayment = DateTime.Parse("2024-08-25 02:50:35.970"),
                    PaymentId = "PAYID-M3FH7UI2F8801196Y263471T"
                },
                new Payment()
                {
                    Id = 2,
                    Method = "PayPal",
                    Amount = 776.18m,
                    TimeOfPayment = DateTime.Parse("2024-08-25 02:53:25.430"),
                    PaymentId = "PAYID-M3FIA6Y29T10926Y2305973M"
                }
            );

            modelBuilder.Entity<ShippingInfo>().HasData
            (
                new ShippingInfo()
                {
                    Id = 1,
                    Country = "United States",
                    StateOrProvince = "California",
                    City = "San Francisco",
                    ZipCode = "94107",
                    StreetAddress = "123 Market Street"
                },
                new ShippingInfo()
                {
                    Id = 2,
                    Country = "Canada",
                    StateOrProvince = "Ontario",
                    City = "Toronto",
                    ZipCode = "M5A 1A1",
                    StreetAddress = "456 Queen Street West"
                }
            );

            modelBuilder.Entity<OrderHeader>().HasData
            (
                new OrderHeader()
                {
                    Id = 1,
                    OrderNumber = "ORD4371386",
                    CustomerId = 1,
                    PaymentId = 1,
                    ShippingInfoId = 1,
                    Status = PULSE.Model.OrderState.Delivered,
                    TimeProcessed = DateTime.Parse("2024-08-25 20:51:29.623"),
                    TimePacked = DateTime.Parse("2024-08-25 20:51:41.897"),
                    TimeShipped = DateTime.Parse("2024-08-25 20:57:12.727"),
                    TimeDelivered = DateTime.Parse("2024-08-25 21:09:47.870"),
                    OnlineOrder = false,
                    Delivery = true,
                    ShippingConst = 123.00m
                },
                new OrderHeader()
                {
                    Id = 2,
                    OrderNumber = "ORD4666406",
                    CustomerId = 1,
                    PaymentId = 2,
                    ShippingInfoId = 2,
                    Status = PULSE.Model.OrderState.Shipped,
                    TimeProcessed = DateTime.Parse("2024-08-25 21:23:40.760"),
                    TimePacked = DateTime.Parse("2024-08-25 21:23:44.133"),
                    TimeShipped = DateTime.Parse("2024-08-25 21:32:43.290"),
                    TimeDelivered = null,
                    OnlineOrder = false,
                    Delivery = true,
                    ShippingConst = 123.00m
                }
            );

            modelBuilder.Entity<OrderDetailBicycle>().HasData
            (
                new OrderDetailBicycle()
                {
                    Id = 1,
                    OrderId = 1,
                    ProductId = 1,
                    UnitPrice = 364.38m,
                    Quantity = 1,
                    Discriminator = "Bicycle",
                    BicycleSizeId = 1
                },
                new OrderDetailBicycle()
                {
                    Id = 2,
                    OrderId = 1,
                    ProductId = 3,
                    UnitPrice = 2900.49m,
                    Quantity = 2,
                    Discriminator = "Bicycle",
                    BicycleSizeId = 3
                },

                new OrderDetailBicycle()
                {
                    Id = 3,
                    OrderId = 2,
                    ProductId = 2,
                    UnitPrice = 3201.41m,
                    Quantity = 1,
                    Discriminator = "Bicycle",
                    BicycleSizeId = 2
                },
                new OrderDetailBicycle()
                {
                    Id = 4,
                    OrderId = 2,
                    ProductId = 5,
                    UnitPrice = 709.01m,
                    Quantity = 1,
                    Discriminator = "Bicycle",
                    BicycleSizeId = 4
                }
            );

            modelBuilder.Entity<OrderDetailPart>().HasData
            (
                new OrderDetailPart()
                {
                    Id = 5,
                    OrderId = 1,
                    ProductId = 16,
                    UnitPrice = 34.99m,
                    Quantity = 2,
                    Discriminator = "Part"
                },
                new OrderDetailPart()
                {
                    Id = 6,
                    OrderId = 1,
                    ProductId = 17,
                    UnitPrice = 89.99m,
                    Quantity = 1,
                    Discriminator = "Part"
                },

                new OrderDetailPart()
                {
                    Id = 7,
                    OrderId = 2,
                    ProductId = 18,
                    UnitPrice = 25.50m,
                    Quantity = 4,
                    Discriminator = "Part"
                },
                new OrderDetailPart()
                {
                    Id = 8,
                    OrderId = 2,
                    ProductId = 19,
                    UnitPrice = 45.75m,
                    Quantity = 2,
                    Discriminator = "Part"
                }
            );

            modelBuilder.Entity<OrderDetailGear>().HasData
            (
                new OrderDetailGear()
                {
                    Id = 9,
                    OrderId = 1,
                    ProductId = 13,
                    UnitPrice = 27.99m,
                    Quantity = 3,
                    Discriminator = "Gear"
                },
                new OrderDetailGear()
                {
                    Id = 10,
                    OrderId = 1,
                    ProductId = 15,
                    UnitPrice = 15.49m,
                    Quantity = 2,
                    Discriminator = "Gear"
                },

                new OrderDetailGear()
                {
                    Id = 11,
                    OrderId = 2,
                    ProductId = 10,
                    UnitPrice = 12.99m,
                    Quantity = 4,
                    Discriminator = "Gear"
                },
                new OrderDetailGear()
                {
                    Id = 12,
                    OrderId = 2,
                    ProductId = 12,
                    UnitPrice = 22.75m,
                    Quantity = 1,
                    Discriminator = "Gear"
                }
            );

            modelBuilder.Entity<Servicing>().HasData
            (
                new Servicing()
                {
                    Id = 1,
                    ServicingNumber = "SERV-234235211",
                    CustomerId = 1,
                    PaymentId = null,
                    CustomerRequest = "Replace the front wheel and adjust the brakes.",
                    Status = 3,
                    OnlinePayment = false,
                    LabourCost = 75.00m,
                    OfferDetails = "Discount on labour for first-time customers.",
                    CreatedAt = DateTime.Parse("2024-08-25 14:30:00.000"),
                    UpdatedAt = DateTime.Parse("2024-08-25 14:30:00.000")
                },
                new Servicing()
                {
                    Id = 2,
                    ServicingNumber = "SERV-345678912",
                    CustomerId = 1,
                    PaymentId = null,
                    CustomerRequest = "Full service and tune-up.",
                    Status = 1,
                    OnlinePayment = false,
                    LabourCost = 120.00m,
                    OfferDetails = "Includes free bike check-up with full service.",
                    CreatedAt = DateTime.Parse("2024-08-26 10:15:00.000"),
                    UpdatedAt = DateTime.Parse("2024-08-26 10:15:00.000")
                }
            );

            modelBuilder.Entity<ServicingPart>().HasData
            (
                new ServicingPart()
                {
                    ServicingId = 1,
                    ProductId = 17,
                    UnitPrice = 89.99m,
                    Quantity = 1
                },
                new ServicingPart()
                {
                    ServicingId = 1,
                    ProductId = 18,
                    UnitPrice = 25.50m,
                    Quantity = 2
                },

                new ServicingPart()
                {
                    ServicingId = 2,
                    ProductId = 16,
                    UnitPrice = 34.99m,
                    Quantity = 1
                },
                new ServicingPart()
                {
                    ServicingId = 2,
                    ProductId = 17,
                    UnitPrice = 89.99m,
                    Quantity = 1
                },
                new ServicingPart()
                {
                    ServicingId = 2,
                    ProductId = 18,
                    UnitPrice = 25.50m,
                    Quantity = 2
                }
            );

        }
    }
}
