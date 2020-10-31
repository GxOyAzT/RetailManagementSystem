using Microsoft.EntityFrameworkCore;
using Models;

namespace DatabaseModule
{
    public partial class ShopContext : DbContext
    {
        public ShopContext()
        {

        }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {

        }

        public virtual DbSet<ProducerModel> Producers { get; set; }
        public virtual DbSet<ProductBasicsModel> ProductBasicsModels { get; set; }
        public virtual DbSet<ProductPriceModel> ProductPriceModels { get; set; }
        public virtual DbSet<ProductStorageModel> ProductStorageModels { get; set; }
        public virtual DbSet<ProductAvaliabilityModel> ProductAvaliabilityModels { get; set; }
        public virtual DbSet<ShopModel> ShopModels { get; set; }
        public virtual DbSet<TruckModel> TruckModels { get; set; }
        public virtual DbSet<WarehouseModel> WarehouseModels { get; set; }
        public virtual DbSet<WarehouseChangesModel> WarehouseChangesModels { get; set; }
        public virtual DbSet<OrderModel> OrderModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Trusted_Connection=true;Database=ShopTests;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProducerModel>(entity =>
            {
                entity.ToTable("Producer", "pr");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Name");
            });

            modelBuilder.Entity<ProductBasicsModel>(entity =>
            {
                entity.ToTable("Product", "pr");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Barecode)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(e => e.ProducerModel)
                    .WithMany(p => p.ProductBasicsModels)
                    .HasForeignKey(d => d.ProducerId)
                    .HasConstraintName("FK__Product__Produce__29572725");

                entity.Property(e => e.ProducerId)
                    .HasColumnName("Producer_Id");
            });

            modelBuilder.Entity<ProductPriceModel>(entity =>
            {
                entity.ToTable("ActualPriceAndTax", "pr");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasKey(e => e.ProductId);

                entity.HasOne(e => e.ProductBasicsModel)
                    .WithOne(p => p.ProductPriceModel)
                    .HasForeignKey<ProductBasicsModel>(d => d.Id)
                    .HasConstraintName("FK__ActualPri__Produ__2C3393D0");
            });

            modelBuilder.Entity<ProductStorageModel>(entity =>
            {
                entity.ToTable("ProductStorage", "pr");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasKey(e => e.ProductId);

                entity.HasOne(e => e.ProductBasicsModel)
                    .WithOne(p => p.ProductStorageModel)
                    .HasForeignKey<ProductBasicsModel>(d => d.Id)
                    .HasConstraintName("FK__ProductSt__Produ__2F10007B");
            });

            modelBuilder.Entity<ProductAvaliabilityModel>(entity =>
            {
                entity.ToTable("ProductAvaliability", "pr");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasKey(e => e.ProductId);

                entity.HasOne(e => e.ProductBasicsModel)
                    .WithOne(p => p.ProductAvaliabilityModel)
                    .HasForeignKey<ProductBasicsModel>(d => d.Id)
                    .HasConstraintName("FK__ProductAv__Produ__31EC6D26");
            });

            modelBuilder.Entity<ShopModel>(entity =>
            {
                entity.ToTable("Shop", "sh");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckModel>(entity =>
            {
                entity.ToTable("Truck", "cr");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasIndex(e => e.Name)
                    .IsUnique();
            });

            modelBuilder.Entity<WarehouseModel>(entity =>
            {
                entity.ToTable("Warehouse", "st");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasKey(e => e.ProductId);

                entity.HasOne(e => e.ProductBasicsModel)
                    .WithOne(d => d.WarehouseModel)
                    .HasForeignKey<ProductBasicsModel>(x => x.Id)
                    .HasConstraintName("FK__Warehouse__Produ__4CA06362");
            });

            modelBuilder.Entity<WarehouseChangesModel>(entity =>
            {
                entity.ToTable("WarehouseChanges", "st");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasKey(e => e.ProductId);

                entity.HasOne(e => e.ProductBasicsModel)
                    .WithMany(d => d.WarehouseChangesModels)
                    .HasForeignKey(x => x.ProductId)
                    .HasConstraintName("FK__Warehouse__Produ__52593CB8");
            });

            modelBuilder.Entity<OrderModel>(entity =>
            {
                entity.ToTable("Order", "cr");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.ShopId).HasColumnName("Shop_Id");

                entity.HasOne(e => e.ShopModel)
                    .WithMany(d => d.OrderModels)
                    .HasForeignKey(x => x.ShopId)
                    .HasConstraintName("FK__Order__Shop_Id__76969D2E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
