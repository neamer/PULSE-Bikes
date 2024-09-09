using Microsoft.EntityFrameworkCore;

namespace PULSE.Services.Data
{
    public partial class PULSEContext : DbContext
    {
        public PULSEContext()
        {
        }

        public PULSEContext(DbContextOptions<PULSEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AvailableSize> AvailableSizes { get; set; } = null!;
        public virtual DbSet<BicycleSize> BicycleSizes { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<OrderDetailBicycle> OrderDetailBicycles { get; set; } = null!;
        public virtual DbSet<OrderDetailPart> OrderDetailParts { get; set; } = null!;
        public virtual DbSet<OrderDetailGear> OrderDetailGear { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetail { get; set; } = null!;
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Part> Parts { get; set; } = null!;
        public virtual DbSet<Gear> Gear { get; set; } = null!;
        public virtual DbSet<Bicycle> Bicycles { get; set; } = null!;
        public virtual DbSet<PartCategory> PartCategories { get; set; } = null!;
        public virtual DbSet<GearCategory> GearCategories { get; set; } = null!;
        public virtual DbSet<BicycleCategory> BicycleCategories { get; set; } = null!;
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
                optionsBuilder.UseSqlServer("Data Source=192.168.1.18, 1434;Initial Catalog=PULSE; user=sa; Password=QWEasd123!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailableSize>(entity =>
            {
                entity.ToTable("AvailableSize");

                entity.Property(e => e.BicycleSizeId).HasColumnName("BicycleSizeID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.BicycleSize)
                    .WithMany(p => p.AvailableSizes)
                    .HasForeignKey(d => d.BicycleSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AvailableSize_BicycleSize");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.AvailableSizes)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AvailableSize_Bicycle");
            });

            modelBuilder.Entity<BicycleSize>(entity =>
            {
                entity.ToTable("BicycleSize");

                entity.Property(e => e.Size).HasMaxLength(15);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

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

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.HasDiscriminator(p => p.Discriminator)
                    .HasValue<OrderDetailPart>("Part")
                    .HasValue<OrderDetailGear>("Gear")
                    .HasValue<OrderDetailBicycle>("Bicycle");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<OrderDetailBicycle>(entity =>
            {
                entity.Property(e => e.BicycleSizeId).HasColumnName("BicycleSizeID");

                entity.HasOne(d => d.BicycleSize)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.BicycleSizeId)
                    .HasConstraintName("FK_OrderDetail_BicycleSize");
            });

            modelBuilder.Entity<OrderHeader>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("OrderHeader");

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
                    .WithMany()
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_OrderHeader_Payment");

                entity.HasOne(d => d.ShippingInfo)
                    .WithMany(p => p.OrderHeaders)
                    .HasForeignKey(d => d.ShippingInfoId)
                    .HasConstraintName("FK_OrderHeader_ShippingInfo");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.Method).HasMaxLength(30);

                entity.Property(e => e.Method).HasMaxLength(200);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeOfPayment).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasDiscriminator(p => p.Discriminator)
                    .HasValue<Part>("Part")
                    .HasValue<Gear>("Gear")
                    .HasValue<Bicycle>("Bicycle");

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

            modelBuilder.Entity<Part>(entity =>
            {
                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.AvailableQty).HasColumnName("AvailableQty");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Part)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_Product_ProductCategory");
            });

            modelBuilder.Entity<Gear>(entity =>
            {
                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.AvailableQty).HasColumnName("AvailableQty");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Gear)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_Product_ProductCategory");
            });

            modelBuilder.Entity<Bicycle>(entity =>
            {
                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WheelSize)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Bicycle)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_Product_ProductCategory");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory");

                entity.HasDiscriminator(p => p.Discriminator)
                    .HasValue<PartCategory>("Part")
                    .HasValue<GearCategory>("Gear")
                    .HasValue<BicycleCategory>("Bicycle");

                entity.Property(e => e.Discriminator).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("ProductImage");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Images)
                    .OnDelete(DeleteBehavior.ClientCascade)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductImage_Product");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            modelBuilder.Entity<Servicing>(entity =>
            {
                entity.ToTable("Servicing");

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
                    .WithMany()
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

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.StateOrProvince).HasMaxLength(50);

                entity.Property(e => e.StreetAddress).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(12);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

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

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.staff)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Staff_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
