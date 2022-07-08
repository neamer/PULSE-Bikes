using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PULSE.Services.Database
{
    public partial class PULSEdbContext : DbContext
    {
        public PULSEdbContext()
        {
        }

        public PULSEdbContext(DbContextOptions<PULSEdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AvailableSize> AvailableSizes { get; set; } = null!;
        public virtual DbSet<Bicycle> Bicycles { get; set; } = null!;
        public virtual DbSet<BicycleSize> BicycleSizes { get; set; } = null!;
        public virtual DbSet<BicycleType> BicycleTypes { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Gear> Gears { get; set; } = null!;
        public virtual DbSet<GearCategory> GearCategories { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; } = null!;
        public virtual DbSet<Part> Parts { get; set; } = null!;
        public virtual DbSet<PartCategory> PartCategories { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductImage> ProductImages { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Servicing> Servicings { get; set; } = null!;
        public virtual DbSet<ServicingPart> ServicingParts { get; set; } = null!;
        public virtual DbSet<ShippingInfo> ShippingInfos { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost, 1434;Initial Catalog=PULSEdb; user=sa; Password=QWEasd123!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailableSize>(entity =>
            {
                entity.HasKey(e => new { e.BicycleSizeId, e.BicycleId });

                entity.ToTable("AvailableSize");

                entity.Property(e => e.BicycleSizeId).HasColumnName("BicycleSizeID");

                entity.Property(e => e.BicycleId).HasColumnName("BicycleID");

                entity.HasOne(d => d.Bicycle)
                    .WithMany(p => p.AvailableSizes)
                    .HasForeignKey(d => d.BicycleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AvailableSize_Bicycle");

                entity.HasOne(d => d.BicycleSize)
                    .WithMany(p => p.AvailableSizes)
                    .HasForeignKey(d => d.BicycleSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AvailableSize_BicycleSize");
            });

            modelBuilder.Entity<Bicycle>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("Bicycle");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.BicycleTypeId).HasColumnName("BicycleTypeID");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WheelSize)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.BicycleType)
                    .WithMany(p => p.Bicycles)
                    .HasForeignKey(d => d.BicycleTypeId)
                    .HasConstraintName("FK_Bicycle_BicycleType");

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.Bicycle)
                    .HasForeignKey<Bicycle>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bicycle_Product");
            });

            modelBuilder.Entity<BicycleSize>(entity =>
            {
                entity.ToTable("BicycleSize");

                entity.Property(e => e.BicycleSizeId).HasColumnName("BicycleSizeID");

                entity.Property(e => e.Size).HasMaxLength(15);
            });

            modelBuilder.Entity<BicycleType>(entity =>
            {
                entity.ToTable("BicycleType");

                entity.Property(e => e.BicycleTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("BicycleTypeID");

                entity.Property(e => e.Name).HasMaxLength(1);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PasswordHash).HasMaxLength(50);

                entity.Property(e => e.PasswordSalt).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.ShippingInfoId).HasColumnName("ShippingInfoID");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.ShippingInfo)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ShippingInfoId)
                    .HasConstraintName("FK_Customer_ShippingInfo");
            });

            modelBuilder.Entity<Gear>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("Gear");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.GearCategoryId).HasColumnName("GearCategoryID");

                entity.HasOne(d => d.GearCategory)
                    .WithMany(p => p.Gears)
                    .HasForeignKey(d => d.GearCategoryId)
                    .HasConstraintName("FK_Gear_GearCategory");

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.Gear)
                    .HasForeignKey<Gear>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gear_Product");
            });

            modelBuilder.Entity<GearCategory>(entity =>
            {
                entity.ToTable("GearCategory");

                entity.Property(e => e.GearCategoryId).HasColumnName("GearCategoryID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.OrderDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("OrderDetailID");

                entity.Property(e => e.BicycleSizeId).HasColumnName("BicycleSizeID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.BicycleSize)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.BicycleSizeId)
                    .HasConstraintName("FK_OrderDetail_BicycleSize");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<OrderHeader>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("OrderHeader");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderNumber).HasMaxLength(50);

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.ShippingConst).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShippingInfoId).HasColumnName("ShippingInfoID");

                entity.Property(e => e.TimeDelivered).HasColumnType("datetime");

                entity.Property(e => e.TimePacked).HasColumnType("datetime");

                entity.Property(e => e.TimeProcessed).HasColumnType("datetime");

                entity.Property(e => e.TimeShipped).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrderHeaders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_OrderHeader_Customer");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.OrderHeaders)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_OrderHeader_Payment");

                entity.HasOne(d => d.ShippingInfo)
                    .WithMany(p => p.OrderHeaders)
                    .HasForeignKey(d => d.ShippingInfoId)
                    .HasConstraintName("FK_OrderHeader_ShippingInfo");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("Part");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProductID");

                entity.Property(e => e.PartCategoryId).HasColumnName("PartCategoryID");

                entity.HasOne(d => d.PartCategory)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.PartCategoryId)
                    .HasConstraintName("FK_Part_PartCategory");

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.Part)
                    .HasForeignKey<Part>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Part_Product");
            });

            modelBuilder.Entity<PartCategory>(entity =>
            {
                entity.ToTable("PartCategory");

                entity.Property(e => e.PartCategoryId).HasColumnName("PartCategoryID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Method).HasMaxLength(30);

                entity.Property(e => e.TimeOfPayment).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Discriminator)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Model).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductNumber).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Product_Brand");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("ProductImage");

                entity.Property(e => e.ProductImageId).HasColumnName("ProductImageID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductImage_Product");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Servicing>(entity =>
            {
                entity.ToTable("Servicing");

                entity.Property(e => e.ServicingId).HasColumnName("ServicingID");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.LabourCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.ServicingNumber).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Servicings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Servicing_Customer");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Servicings)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Servicing_Payment");
            });

            modelBuilder.Entity<ServicingPart>(entity =>
            {
                entity.HasKey(e => new { e.ServicingId, e.ProductId });

                entity.ToTable("ServicingPart");

                entity.Property(e => e.ServicingId).HasColumnName("ServicingID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ServicingParts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServicingPart_Part");

                entity.HasOne(d => d.Servicing)
                    .WithMany(p => p.ServicingParts)
                    .HasForeignKey(d => d.ServicingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServicingPart_Servicing");
            });

            modelBuilder.Entity<ShippingInfo>(entity =>
            {
                entity.ToTable("ShippingInfo");

                entity.Property(e => e.ShippingInfoId).HasColumnName("ShippingInfoID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.StateOrProvince).HasMaxLength(50);

                entity.Property(e => e.StreetAddress).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(12);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DateOfEmployment).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PasswordHash).HasMaxLength(50);

                entity.Property(e => e.PasswordSalt).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.staff)
                    .UsingEntity<Dictionary<string, object>>(
                        "StaffRole",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_StaffRole_Role"),
                        r => r.HasOne<staff>().WithMany().HasForeignKey("StaffId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_StaffRole_Staff"),
                        j =>
                        {
                            j.HasKey("StaffId", "RoleId");

                            j.ToTable("StaffRole");

                            j.IndexerProperty<int>("StaffId").HasColumnName("StaffID");

                            j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
