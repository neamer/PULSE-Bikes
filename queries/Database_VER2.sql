CREATE DATABASE PULSE2
go

use PULSE2
go


-- STAFF SECTION

CREATE TABLE Staff
(
	Id int IDENTITY(1,1),
	RoleID int,
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
	CONSTRAINT PK_Staff PRIMARY KEY(Id)
);

CREATE TABLE Role
(
	Id int IDENTITY(1,1),
	Name nvarchar(20),
	CONSTRAINT PK_Role PRIMARY KEY(Id)
);

CREATE TABLE StaffRole
(
	StaffID int,
	RoleID int,
	CONSTRAINT PK_StaffRole PRIMARY KEY (StaffID, RoleID),
	CONSTRAINT FK_StaffRole_Staff FOREIGN KEY (StaffID) REFERENCES Staff (Id),
	CONSTRAINT FK_StaffRole_Role FOREIGN KEY (RoleID) REFERENCES Role (Id),
)


-- PRODUCT SECTION

CREATE TABLE Brand
(
	Id int IDENTITY(1,1),
	Name nvarchar(20)
	CONSTRAINT PK_Brand PRIMARY KEY (Id)
);

CREATE TABLE ProductCategory
(
	Id int IDENTITY(1,1),
	Name nvarchar(50),
	Discriminator nvarchar(10),
	CONSTRAINT PK_ProductCategory PRIMARY KEY(Id)
);

--CREATE TABLE Product
--(
--	ProductID int IDENTITY(1,1),
--	BrandID int,
--	ProductCategoryID int,
--	ProductNumber nvarchar(50),
--	Model nvarchar(100),
--	Description nvarchar(1000),
--	Price decimal(18,2),
--	Discriminator varchar(10),
--	ThumbImage varbinary(max),
--	CreatedAt Datetime,
--	UpdatedAt Datetime,
--	CONSTRAINT PK_Product PRIMARY KEY(ProductID),
--	CONSTRAINT FK_Product_Brand FOREIGN KEY (BrandID) REFERENCES Brand (BrandID),
--	CONSTRAINT FK_Product_ProductCategory FOREIGN KEY (ProductCategoryID) REFERENCES ProductCategory (ProductCategoryID),
--);

CREATE TABLE Product
(
	Id int IDENTITY(1,1),
	BrandID int,
	ProductCategoryID int,
	ProductNumber nvarchar(50),
	Model nvarchar(100),
	Description nvarchar(max),
	Price decimal(18,2),
	Discriminator varchar(10),
	ThumbImage varbinary(max),

	--Bicycle
	Weight decimal(18,4),
	ProductionYear int,
	WheelSize varchar(50),

	--Part and Gear
	AvailableQty int,

	CreatedAt Datetime,
	UpdatedAt Datetime,
	CONSTRAINT PK_Product PRIMARY KEY(Id),
	CONSTRAINT FK_Product_Brand FOREIGN KEY (BrandID) REFERENCES Brand (Id),
	CONSTRAINT FK_Product_ProductCategory FOREIGN KEY (ProductCategoryID) REFERENCES ProductCategory (Id),
);

CREATE TABLE ProductImage
(
	Id int IDENTITY(1,1),
	ProductID int,
	Data varbinary(max),
	CreatedAt Datetime,
	UpdatedAt Datetime,
	CONSTRAINT FK_ProductImage_Product FOREIGN KEY (ProductID) REFERENCES Product (Id)
);



--CREATE TABLE Bicycle
--(
--	ProductID int,
--	BicycleTypeID int,
--	Weight decimal(18,4),
--	ProductionYear int,
--	WheelSize varchar
--	CONSTRAINT PK_Bicycle PRIMARY KEY(ProductID)
--	CONSTRAINT FK_Bicycle_Product FOREIGN KEY (ProductID) REFERENCES Product (ProductID),
--	CONSTRAINT FK_Bicycle_BicycleType FOREIGN KEY (BicycleTypeID) REFERENCES BicycleType (BicycleTypeID),
--)

CREATE TABLE BicycleSize
(
	Id int IDENTITY(1,1),
	Size nvarchar(15)
	CONSTRAINT PK_BicycleSize PRIMARY KEY (Id)
);

CREATE TABLE AvailableSize 
(
	Id int IDENTITY(1,1),
	BicycleSizeID int,
	ProductID int,
	AvailableQty int,
	CONSTRAINT PK_AvailableSize PRIMARY KEY(Id),
	CONSTRAINT FK_AvailableSize_BicycleSize FOREIGN KEY (BicycleSizeID) REFERENCES BicycleSize (Id),
	CONSTRAINT FK_AvailableSize_Bicycle FOREIGN KEY (ProductID) REFERENCES Product (Id)
);

--CREATE TABLE GearCategory
--(
--	GearCategoryID int IDENTITY(1,1),
--	Name nvarchar(50),
--	CONSTRAINT PK_GearCategory PRIMARY KEY(GearCategoryID)
--);

--CREATE TABLE Gear
--(
--	ProductID int,
--	GearCategoryID int,
--	AvailableQty int,
--	CONSTRAINT PK_Gear PRIMARY KEY(ProductID),
--	CONSTRAINT FK_Gear_Product FOREIGN KEY (ProductID) REFERENCES Product (ProductID),
--	CONSTRAINT FK_Gear_GearCategory FOREIGN KEY (GearCategoryID) REFERENCES GearCategory (GearCategoryID),
--)

--CREATE TABLE PartCategory
--(
--	PartCategoryID int IDENTITY(1,1),
--	Name nvarchar(50),
--	CONSTRAINT PK_PartCategory PRIMARY KEY(PartCategoryID)
--);

--CREATE TABLE Part
--(
--	ProductID int,
--	PartCategoryID int,
--	AvailableQty int,
--	CONSTRAINT PK_Part PRIMARY KEY(ProductID),
--	CONSTRAINT FK_Part_PartCategory FOREIGN KEY (PartCategoryID) REFERENCES PartCategory (PartCategoryID),
--)

--ALTER TABLE Part
--ADD CONSTRAINT FK_Part_Product FOREIGN KEY (ProductID) REFERENCES Product (ProductID)

--CUSTOMER SECTION

CREATE TABLE ShippingInfo
(
	Id int IDENTITY(1,1),
	Country nvarchar(50),
	StateOrProvince nvarchar(50),
	City nvarchar(50),
	ZipCode nvarchar(12),
	StreetAddress nvarchar(50),
	CONSTRAINT PK_ShippingInfo PRIMARY KEY (Id)
);

CREATE TABLE Customer
(
	Id int IDENTITY(1,1),
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
	CONSTRAINT PK_Customer PRIMARY KEY(Id),
	CONSTRAINT FK_Customer_ShippingInfo FOREIGN KEY (ShippingInfoID) REFERENCES ShippingInfo (Id),
);

--ORDER SECTION

CREATE TABLE Payment
(
	Id int IDENTITY(1,1),
	Method nvarchar(30),
	Amount decimal(18,2),
	TimeOfPayment datetime
	CONSTRAINT PK_Payment PRIMARY KEY (Id)
);

CREATE TABLE OrderHeader
(
	Id int IDENTITY(1,1),
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
	CONSTRAINT PK_OrderHeader PRIMARY KEY (Id),
	CONSTRAINT FK_OrderHeader_Customer FOREIGN KEY (CustomerID) REFERENCES Customer (Id),
	CONSTRAINT FK_OrderHeader_Payment FOREIGN KEY (PaymentID) REFERENCES Payment (Id),
	CONSTRAINT FK_OrderHeader_ShippingInfo FOREIGN KEY (ShippingInfoID) REFERENCES ShippingInfo (Id),
);

CREATE TABLE OrderDetail
(
	Id int IDENTITY(1,1),
	OrderID int,
	ProductID int,
	BicycleSizeID int null,
	UnitPrice decimal(18,2),
	Quantity int,
	Discriminator varchar(50),
	CONSTRAINT PK_OrderDetail PRIMARY KEY (Id),
	CONSTRAINT FK_OrderDetail_Order FOREIGN KEY (OrderID) REFERENCES OrderHeader (Id) ON DELETE CASCADE,
	CONSTRAINT FK_OrderDetail_Product FOREIGN KEY (ProductID) REFERENCES Product (Id),
	CONSTRAINT FK_OrderDetail_BicycleSize FOREIGN KEY (BicycleSizeID) REFERENCES BicycleSize (Id),
);

CREATE TABLE Servicing
(
	Id int IDENTITY(1,1),
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
	CONSTRAINT PK_Servicing PRIMARY KEY (Id),
	CONSTRAINT FK_Servicing_Customer FOREIGN KEY (CustomerID) REFERENCES Customer (Id),
	CONSTRAINT FK_Servicing_Payment FOREIGN KEY (PaymentID) REFERENCES Payment (Id),
);

CREATE TABLE ServicingPart
(
	ServicingID int,
	ProductID int,
	UnitPrice decimal(18,2),
	Quantity int,
	CONSTRAINT PK_ServicingPart PRIMARY KEY (ServicingID, ProductID),
	CONSTRAINT FK_ServicingPart_Servicing FOREIGN KEY (ServicingID) REFERENCES Servicing (Id),
	CONSTRAINT FK_ServicingPart_Part FOREIGN KEY (ProductID) REFERENCES Product (Id),
);

ALTER TABLE Product
ALTER COLUMN WheelSize nvarchar(50);

ALTER TABLE Payment
ADD Amount decimal(18,2)