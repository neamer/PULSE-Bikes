CREATE DATABASE PULSEdb
go

use PULSEdb
go


-- STAFF SECTION


CREATE TABLE Staff
(
	StaffID int IDENTITY(1,1),
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Username nvarchar(50),
	Email nvarchar(100),
	PasswordHash nvarchar(50),
	PasswordSalt nvarchar(50),
	Status bit,
	PhoneNumber nvarchar(20),
	DateOfBirth date,
	DateOfEmployment date,
	CreatedAt Datetime,
	UpdatedAt Datetime,
	CONSTRAINT PK_Staff PRIMARY KEY(StaffID)
);

CREATE TABLE Role
(
	RoleID int IDENTITY(1,1),
	Name nvarchar(20),
	CONSTRAINT PK_Role PRIMARY KEY(RoleID)
);

CREATE TABLE StaffRole
(
	StaffID int,
	RoleID int,
	CONSTRAINT PK_StaffRole PRIMARY KEY (StaffID, RoleID),
	CONSTRAINT FK_StaffRole_Staff FOREIGN KEY (StaffID) REFERENCES Staff (StaffID),
	CONSTRAINT FK_StaffRole_Role FOREIGN KEY (RoleID) REFERENCES Role (RoleID),
)


-- PRODUCT SECTION

CREATE TABLE Brand
(
	BrandID int IDENTITY(1,1),
	Name nvarchar(20)
	CONSTRAINT PK_Brand PRIMARY KEY (BrandID)
);

CREATE TABLE Product
(
	ProductID int IDENTITY(1,1),
	BrandID int,
	ProductNumber nvarchar(50),
	Model nvarchar(100),
	Description nvarchar(1000),
	Price decimal(18,2),
	Discriminator varchar(10),
	CreatedAt Datetime,
	UpdatedAt Datetime,
	CONSTRAINT PK_Product PRIMARY KEY(ProductID),
	CONSTRAINT FK_Product_Brand FOREIGN KEY (BrandID) REFERENCES Brand (BrandID),
);

ALTER TABLE Product
ADD ThumbImage varbinary(max)

CREATE TABLE ProductImage
(
	ProductImageID int IDENTITY(1,1),
	ProductID int,
	Image varbinary(max)
	CONSTRAINT PK_ProductImage PRIMARY KEY (ProductImageID),
	CONSTRAINT FK_ProductImage_Product FOREIGN KEY (ProductID) REFERENCES Product (ProductID)
);

CREATE TABLE BicycleType
(
	BicycleTypeID int,
	Name nvarchar
	CONSTRAINT PK_BicycleType PRIMARY KEY(BicycleTypeID)
);

CREATE TABLE Bicycle
(
	ProductID int,
	BicycleTypeID int,
	Weight decimal(18,4),
	ProductionYear int,
	WheelSize varchar
	CONSTRAINT PK_Bicycle PRIMARY KEY(ProductID)
	CONSTRAINT FK_Bicycle_Product FOREIGN KEY (ProductID) REFERENCES Product (ProductID),
	CONSTRAINT FK_Bicycle_BicycleType FOREIGN KEY (BicycleTypeID) REFERENCES BicycleType (BicycleTypeID),
)

CREATE TABLE BicycleSize
(
	BicycleSizeID int IDENTITY(1,1),
	Size nvarchar(15)
	CONSTRAINT PK_BicycleSize PRIMARY KEY (BicycleSizeID)
);

CREATE TABLE AvailableSize 
(
	BicycleSizeID int,
	BicycleID int,
	AvailableQty int,
	CONSTRAINT PK_AvailableSize PRIMARY KEY(BicycleSizeID, BicycleID),
	CONSTRAINT FK_AvailableSize_BicycleSize FOREIGN KEY (BicycleSizeID) REFERENCES BicycleSize (BicycleSizeID),
	CONSTRAINT FK_AvailableSize_Bicycle FOREIGN KEY (BicycleID) REFERENCES Bicycle (ProductID)
);

CREATE TABLE GearCategory
(
	GearCategoryID int IDENTITY(1,1),
	Name nvarchar(50),
	CONSTRAINT PK_GearCategory PRIMARY KEY(GearCategoryID)
);

CREATE TABLE Gear
(
	ProductID int,
	GearCategoryID int,
	AvailableQty int,
	CONSTRAINT PK_Gear PRIMARY KEY(ProductID),
	CONSTRAINT FK_Gear_Product FOREIGN KEY (ProductID) REFERENCES Product (ProductID),
	CONSTRAINT FK_Gear_GearCategory FOREIGN KEY (GearCategoryID) REFERENCES GearCategory (GearCategoryID),
)

CREATE TABLE PartCategory
(
	PartCategoryID int IDENTITY(1,1),
	Name nvarchar(50),
	CONSTRAINT PK_PartCategory PRIMARY KEY(PartCategoryID)
);

CREATE TABLE Part
(
	ProductID int,
	PartCategoryID int,
	AvailableQty int,
	CONSTRAINT PK_Part PRIMARY KEY(ProductID),
	CONSTRAINT FK_Part_PartCategory FOREIGN KEY (PartCategoryID) REFERENCES PartCategory (PartCategoryID),
)

ALTER TABLE Part
ADD CONSTRAINT FK_Part_Product FOREIGN KEY (ProductID) REFERENCES Product (ProductID)

--CUSTOMER SECTION

CREATE TABLE ShippingInfo
(
	ShippingInfoID int IDENTITY(1,1),
	Country nvarchar(50),
	StateOrProvince nvarchar(50),
	City nvarchar(50),
	ZipCode nvarchar(12),
	StreetAddress nvarchar(50),
	CONSTRAINT PK_ShippingInfo PRIMARY KEY (ShippingInfoID)
);

CREATE TABLE Customer
(
	CustomerID int IDENTITY(1,1),
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Username nvarchar(50),
	Email nvarchar(100),
	ShippingInfoID int,
	PasswordHash nvarchar(50),
	PasswordSalt nvarchar(50),
	Status bit,
	PhoneNumber nvarchar(20),
	CreatedAt Datetime,
	UpdatedAt Datetime,
	CONSTRAINT PK_Customer PRIMARY KEY(CustomerID),
	CONSTRAINT FK_Customer_ShippingInfo FOREIGN KEY (ShippingInfoID) REFERENCES ShippingInfo (ShippingInfoID),
);

--ORDER SECTION

CREATE TABLE Payment
(
	PaymentID int IDENTITY(1,1),
	Method nvarchar(30),
	TimeOfPayment datetime,
	CONSTRAINT PK_Payment PRIMARY KEY (PaymentID)
);

CREATE TABLE OrderHeader
(
	OrderID int IDENTITY(1,1),
	OrderNumber nvarchar(50),
	CustomerID int,
	PaymentID int,
	ShippingInfoID int null,
	Status int,
	TimeProcessed datetime,
	TimePacked datetime,
	TimeShipped datetime,
	TimeDelivered datetime,
	OnlineOrder bit,
	Delivery bit,
	ShippingConst decimal(18,2),
	CONSTRAINT PK_OrderHeader PRIMARY KEY (OrderID),
	CONSTRAINT FK_OrderHeader_Customer FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID),
	CONSTRAINT FK_OrderHeader_Payment FOREIGN KEY (PaymentID) REFERENCES Payment (PaymentID),
	CONSTRAINT FK_OrderHeader_ShippingInfo FOREIGN KEY (ShippingInfoID) REFERENCES ShippingInfo (ShippingInfoID),
);

CREATE TABLE OrderDetail
(
	OrderDetailID int,
	OrderID int,
	ProductID int,
	BicycleSizeID int null,
	UnitPrice decimal(18,2),
	Quantity int,
	CONSTRAINT PK_OrderDetail PRIMARY KEY (OrderDetailID),
	CONSTRAINT FK_OrderDetail_Order FOREIGN KEY (OrderID) REFERENCES OrderHeader (OrderID),
	CONSTRAINT FK_OrderDetail_Product FOREIGN KEY (ProductID) REFERENCES Product (ProductID),
	CONSTRAINT FK_OrderDetail_BicycleSize FOREIGN KEY (BicycleSizeID) REFERENCES BicycleSize (BicycleSizeID),
);

CREATE TABLE Servicing
(
	ServicingID int IDENTITY(1,1),
	ServicingNumber nvarchar(50),
	CustomerID int,
	PaymentID int,
	CustomerRequest nvarchar(max),
	Status int,
	OnlinePayment bit,
	LabourCost decimal(18,2),
	OfferDetails nvarchar(max),
	CreatedAt Datetime,
	UpdatedAt Datetime,
	CONSTRAINT PK_Servicing PRIMARY KEY (ServicingID),
	CONSTRAINT FK_Servicing_Customer FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID),
	CONSTRAINT FK_Servicing_Payment FOREIGN KEY (PaymentID) REFERENCES Payment (PaymentID),
);

CREATE TABLE ServicingPart
(
	ServicingID int,
	ProductID int,
	UnitPrice decimal(18,2),
	Quantity int,
	CONSTRAINT PK_ServicingPart PRIMARY KEY (ServicingID, ProductID),
	CONSTRAINT FK_ServicingPart_Servicing FOREIGN KEY (ServicingID) REFERENCES Servicing (ServicingID),
	CONSTRAINT FK_ServicingPart_Part FOREIGN KEY (ProductID) REFERENCES Part (ProductID),
);