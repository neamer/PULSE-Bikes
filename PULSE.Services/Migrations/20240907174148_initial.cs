using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PULSE.Services.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BicycleSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BicycleSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Method = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TimeOfPayment = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StateOrProvince = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandID = table.Column<int>(type: "int", nullable: true),
                    ProductCategoryID = table.Column<int>(type: "int", nullable: true),
                    ProductNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Discriminator = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ThumbImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    ProductionYear = table.Column<int>(type: "int", nullable: true),
                    WheelSize = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AvailableQty = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Brand",
                        column: x => x.BrandID,
                        principalTable: "Brand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory",
                        column: x => x.ProductCategoryID,
                        principalTable: "ProductCategory",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    DateOfEmployment = table.Column<DateTime>(type: "date", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Role",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingInfoID = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_ShippingInfo",
                        column: x => x.ShippingInfoID,
                        principalTable: "ShippingInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AvailableSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BicycleSizeID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    AvailableQty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvailableSize_Bicycle",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AvailableSize_BicycleSize",
                        column: x => x.BicycleSizeID,
                        principalTable: "BicycleSize",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderHeader",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    PaymentID = table.Column<int>(type: "int", nullable: true),
                    ShippingInfoID = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    TimeProcessed = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimePacked = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeShipped = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeDelivered = table.Column<DateTime>(type: "datetime", nullable: true),
                    OnlineOrder = table.Column<bool>(type: "bit", nullable: true),
                    Delivery = table.Column<bool>(type: "bit", nullable: true),
                    ShippingConst = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderHeader_Customer",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderHeader_Payment",
                        column: x => x.PaymentID,
                        principalTable: "Payment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderHeader_ShippingInfo",
                        column: x => x.ShippingInfoID,
                        principalTable: "ShippingInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Servicing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicingNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    PaymentID = table.Column<int>(type: "int", nullable: true),
                    CustomerRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    OnlinePayment = table.Column<bool>(type: "bit", nullable: true),
                    LabourCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OfferDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicing_Customer",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Servicing_Payment",
                        column: x => x.PaymentID,
                        principalTable: "Payment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BicycleSizeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_BicycleSize",
                        column: x => x.BicycleSizeID,
                        principalTable: "BicycleSize",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order",
                        column: x => x.OrderID,
                        principalTable: "OrderHeader",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicingPart",
                columns: table => new
                {
                    ServicingID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicingPart", x => new { x.ServicingID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_ServicingPart_Part",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServicingPart_Servicing",
                        column: x => x.ServicingID,
                        principalTable: "Servicing",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "BicycleSize",
                columns: new[] { "Id", "Size" },
                values: new object[,]
                {
                    { 1, "M" },
                    { 2, "S" },
                    { 3, "L" },
                    { 4, "XL" }
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "TREK" },
                    { 2, "CUBE" },
                    { 3, "GIANT" },
                    { 4, "MERIDA" },
                    { 5, "SCOTT" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ShippingInfoID", "Status", "UpdatedAt", "Username" },
                values: new object[] { 1, new DateTime(2022, 8, 25, 14, 58, 56, 843, DateTimeKind.Unspecified), "djohnson@example.com", "Dwayne", "Johnson", "MmGFoK5IT9yQmXu567Yh6ALLvbc=", "0fut3gMif6mwIMaOBzUGYQ==", "+111/222-3334", null, true, new DateTime(2022, 8, 25, 14, 58, 56, 843, DateTimeKind.Unspecified), "djohnson" });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "Amount", "Method", "PaymentId", "TimeOfPayment" },
                values: new object[,]
                {
                    { 1, 776.18m, "PayPal", "PAYID-M3FH7UI2F8801196Y263471T", new DateTime(2024, 8, 25, 2, 50, 35, 970, DateTimeKind.Unspecified) },
                    { 2, 776.18m, "PayPal", "PAYID-M3FIA6Y29T10926Y2305973M", new DateTime(2024, 8, 25, 2, 53, 25, 430, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Discriminator", "Name" },
                values: new object[,]
                {
                    { 5, "Bicycle", "MTB" },
                    { 6, "Bicycle", "Road Bike" },
                    { 7, "Bicycle", "Gravel Bike" },
                    { 20, "Bicycle", "Kids Bike" },
                    { 3, "Gear", "Bottle" },
                    { 4, "Gear", "Bottle Carrier" },
                    { 8, "Gear", "Carrier" },
                    { 9, "Gear", "Jacket" },
                    { 10, "Gear", "Camera 4" },
                    { 11, "Gear", "Rucksack" },
                    { 12, "Gear", "Pouch" },
                    { 13, "Gear", "Illumination" },
                    { 14, "Gear", "Mudguard" },
                    { 15, "Gear", "Basket" },
                    { 1, "Part", "Wheel" },
                    { 2, "Part", "Tire" },
                    { 16, "Part", "Seat" },
                    { 17, "Part", "Rear Derailleur" },
                    { 18, "Part", "V-Brake" },
                    { 19, "Part", "Disk Brake" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Mechanic" },
                    { 3, "Storekeeper" },
                    { 4, "Salesperson" }
                });

            migrationBuilder.InsertData(
                table: "ShippingInfo",
                columns: new[] { "Id", "City", "Country", "StateOrProvince", "StreetAddress", "ZipCode" },
                values: new object[,]
                {
                    { 1, "San Francisco", "United States", "California", "123 Market Street", "94107" },
                    { 2, "Toronto", "Canada", "Ontario", "456 Queen Street West", "M5A 1A1" }
                });

            migrationBuilder.InsertData(
                table: "OrderHeader",
                columns: new[] { "Id", "CustomerID", "Delivery", "OnlineOrder", "OrderNumber", "PaymentID", "ShippingConst", "ShippingInfoID", "Status", "TimeDelivered", "TimePacked", "TimeProcessed", "TimeShipped" },
                values: new object[,]
                {
                    { 1, 1, true, false, "ORD4371386", 1, 123.00m, 1, 7, new DateTime(2024, 8, 25, 21, 9, 47, 870, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 20, 51, 41, 897, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 20, 51, 29, 623, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 20, 57, 12, 727, DateTimeKind.Unspecified) },
                    { 2, 1, true, false, "ORD4666406", 2, 123.00m, 2, 5, null, new DateTime(2024, 8, 25, 21, 23, 44, 133, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 21, 23, 40, 760, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 21, 32, 43, 290, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandID", "CreatedAt", "Description", "Discriminator", "Model", "Price", "ProductCategoryID", "ProductNumber", "ProductionYear", "ThumbImage", "UpdatedAt", "Weight", "WheelSize" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "A high-performance mountain bike designed for rugged terrains with excellent shock absorption and durability.", "Bicycle", "Killer Zebra", 364.38m, 6, "QBXZ-BPZVPK9806", 2010, null, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.2300m, "26" },
                    { 2, 1, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A premium road bike with a sleek design, perfect for speed enthusiasts and long-distance riders.", "Bicycle", "Nile Crocodile", 3201.41m, 6, "WJCM-IOXOZG4968", 2013, null, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.4600m, "29" },
                    { 3, 1, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "A versatile hybrid bike suitable for both city commuting and off-road adventures with a comfortable ride.", "Bicycle", "Plains Zebra", 2900.49m, 6, "TDMC-QYYRUC9454", 2012, null, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0800m, "29" },
                    { 4, 1, new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A durable and robust mountain bike designed to handle the most challenging trails and rough terrains.", "Bicycle", "Northern Elephant Seal", 2693.16m, 5, "LGVC-JWCPLB2398", 2011, null, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.7100m, "26" },
                    { 5, 1, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "A sleek and lightweight bike ideal for city commuting and daily rides, featuring a modern design and efficient performance.", "Bicycle", "Curlew, Black", 709.01m, 6, "UGBJ-KSQIJM0190", 2010, null, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0200m, "29" },
                    { 6, 1, new DateTime(2022, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A high-end road bike with exceptional speed and aerodynamics, designed for competitive cyclists and enthusiasts.", "Bicycle", "Kookaburra, Laughing", 993.63m, 6, "EQKX-QCOLYA9831", 2013, null, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.0200m, "29" },
                    { 7, 2, new DateTime(2022, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "A lightweight bike perfect for urban commuting with a stylish frame and efficient gear system.", "Bicycle", "Black-winged Stilt", 473.14m, 6, "EAOK-QMEEBD8830", 2020, null, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.3500m, "29" },
                    { 8, 2, new DateTime(2022, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "A robust and reliable bike designed for mixed-terrain riding with excellent suspension and durability.", "Bicycle", "Pampa Gray Fox", 2827.99m, 5, "YYMS-JFQGVN8586", 2022, null, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.6400m, "29" },
                    { 9, 1, new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "An all-terrain bike built for adventure seekers, featuring high durability and advanced suspension.", "Bicycle", "Caracara, Yellow", 1401.75m, 6, "ZICU-WPDGRN0328", 2015, null, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.4100m, "27.5" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AvailableQty", "BrandID", "CreatedAt", "Description", "Discriminator", "Model", "Price", "ProductCategoryID", "ProductNumber", "ThumbImage", "UpdatedAt" },
                values: new object[,]
                {
                    { 10, 150, 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Durable and easy-to-clean bottle for hydration during rides.", "Gear", "Cycling Bottle", 8.99m, 3, "BTTL-2314ZK", null, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 80, 1, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Secure and adjustable bottle carrier for various bike frames.", "Gear", "Bike Bottle Carrier", 16.99m, 4, "CCAR-7890LP", null, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 45, 1, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-definition action camera for capturing your adventures on the go.", "Gear", "Action Camera 4", 149.99m, 4, "CAM4-5642QS", null, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 60, 2, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spacious and ergonomic rucksack with multiple compartments for all your cycling gear.", "Gear", "Cycling Rucksack", 55.99m, 4, "RCKS-2904BN", null, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 70, 2, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality waterproof jacket designed for cycling in any weather.", "Gear", "Waterproof Jacket", 89.99m, 4, "JCKT-3345GH", null, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 85, 2, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bright and reliable illumination system to ensure visibility during night rides.", "Gear", "Bike Illumination System", 39.99m, 4, "ILUM-4321FD", null, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 150, 1, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable and ergonomic bike seat for long rides.", "Part", "Seat e", 49.99m, 5, "PSXY-1234AB", null, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 80, 1, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Precision rear derailleur for smooth gear shifting.", "Part", "Rear Derailleur", 89.99m, 5, "RDXY-5678CD", null, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 120, 1, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-performance V-brake for reliable stopping power.", "Part", "V-Brake", 29.99m, 5, "VBRA-9101EF", null, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 60, 2, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Durable disk brake for superior braking performance.", "Part", "Disk Brake", 119.99m, 5, "DBRK-2345GH", null, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Servicing",
                columns: new[] { "Id", "CreatedAt", "CustomerID", "CustomerRequest", "LabourCost", "OfferDetails", "OnlinePayment", "PaymentID", "ServicingNumber", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 25, 14, 30, 0, 0, DateTimeKind.Unspecified), 1, "Replace the front wheel and adjust the brakes.", 75.00m, "Discount on labour for first-time customers.", false, null, "SERV-234235211", 2, new DateTime(2024, 8, 25, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 8, 26, 10, 15, 0, 0, DateTimeKind.Unspecified), 1, "Full service and tune-up.", 120.00m, "Includes free bike check-up with full service.", false, null, "SERV-345678912", 1, new DateTime(2024, 8, 26, 10, 15, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "DateOfEmployment", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "RoleID", "Status", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 25, 14, 58, 56, 843, DateTimeKind.Unspecified), new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "jdoe@example.com", "John", "Doe", "VXbqh5tz66lkaFI8gwiRyB29qbE=", "LijOFjQrJ2ySPafDaJV89g==", "+111/222-3334", 1, true, new DateTime(2022, 8, 25, 14, 58, 56, 843, DateTimeKind.Unspecified), "jdoe" },
                    { 2, new DateTime(2022, 8, 25, 14, 58, 56, 843, DateTimeKind.Unspecified), new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "fthompson@example.com", "Frank", "Thompson", "oRG/dpG4SrYERbbmWle2IHbZoyc=", "8RclDZ3hTHXlWerCumSTNg==", "+111/222-3334", 2, true, new DateTime(2022, 8, 25, 14, 58, 56, 843, DateTimeKind.Unspecified), "fthompson" },
                    { 3, new DateTime(2022, 8, 25, 14, 58, 56, 843, DateTimeKind.Unspecified), new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "mhenry@example.com", "Mark", "Henry", "4chVLh8LhushFpJHkrMLTppXSwE=", "lKQAgzpznhbp136CMQzZrw==", "+111/222-3334", 3, true, new DateTime(2022, 8, 25, 14, 58, 56, 843, DateTimeKind.Unspecified), "mhenry" },
                    { 4, new DateTime(2022, 8, 25, 14, 58, 56, 843, DateTimeKind.Unspecified), new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "janed@example.com", "Jane", "Doe", "76786KICD2CmHC06juN+BvqeHQg=", "VFgOG9JbipvRqaul/+HqBg==", "+111/222-3334", 4, true, new DateTime(2022, 8, 25, 14, 58, 56, 843, DateTimeKind.Unspecified), "janed" }
                });

            migrationBuilder.InsertData(
                table: "AvailableSize",
                columns: new[] { "Id", "AvailableQty", "BicycleSizeID", "ProductID" },
                values: new object[,]
                {
                    { 1, 10, 1, 1 },
                    { 2, 5, 2, 1 },
                    { 3, 8, 3, 2 },
                    { 4, 7, 4, 2 },
                    { 5, 12, 1, 3 },
                    { 6, 8, 3, 3 },
                    { 7, 6, 4, 4 },
                    { 8, 14, 1, 5 },
                    { 9, 11, 2, 5 },
                    { 10, 9, 3, 6 },
                    { 11, 5, 4, 6 },
                    { 12, 10, 1, 7 },
                    { 13, 8, 2, 7 },
                    { 14, 6, 3, 8 },
                    { 15, 4, 4, 8 },
                    { 16, 8, 1, 9 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "BicycleSizeID", "Discriminator", "OrderID", "ProductID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, "Bicycle", 1, 1, 1, 364.38m },
                    { 2, 3, "Bicycle", 1, 3, 2, 2900.49m },
                    { 3, 2, "Bicycle", 2, 2, 1, 3201.41m },
                    { 4, 4, "Bicycle", 2, 5, 1, 709.01m }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "Discriminator", "OrderID", "ProductID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 9, "Gear", 1, 13, 3, 27.99m },
                    { 10, "Gear", 1, 15, 2, 15.49m },
                    { 11, "Gear", 2, 10, 4, 12.99m },
                    { 12, "Gear", 2, 12, 1, 22.75m },
                    { 5, "Part", 1, 16, 2, 34.99m },
                    { 6, "Part", 1, 17, 1, 89.99m },
                    { 7, "Part", 2, 18, 4, 25.50m },
                    { 8, "Part", 2, 19, 2, 45.75m }
                });

            migrationBuilder.InsertData(
                table: "ServicingPart",
                columns: new[] { "ProductID", "ServicingID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 17, 1, 1, 89.99m },
                    { 18, 1, 2, 25.50m },
                    { 16, 2, 1, 34.99m },
                    { 17, 2, 1, 89.99m },
                    { 18, 2, 2, 25.50m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableSize_BicycleSizeID",
                table: "AvailableSize",
                column: "BicycleSizeID");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableSize_ProductID",
                table: "AvailableSize",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ShippingInfoID",
                table: "Customer",
                column: "ShippingInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_BicycleSizeID",
                table: "OrderDetail",
                column: "BicycleSizeID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderID",
                table: "OrderDetail",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductID",
                table: "OrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeader_CustomerID",
                table: "OrderHeader",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeader_PaymentID",
                table: "OrderHeader",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeader_ShippingInfoID",
                table: "OrderHeader",
                column: "ShippingInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandID",
                table: "Product",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryID",
                table: "Product",
                column: "ProductCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductID",
                table: "ProductImage",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Servicing_CustomerID",
                table: "Servicing",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Servicing_PaymentID",
                table: "Servicing",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_ServicingPart_ProductID",
                table: "ServicingPart",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RoleID",
                table: "Staff",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvailableSize");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "ServicingPart");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "BicycleSize");

            migrationBuilder.DropTable(
                name: "OrderHeader");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Servicing");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "ShippingInfo");
        }
    }
}
