using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pr3_3_Up_Uporov.Models;

public partial class StoreSportUporovContext : DbContext
{
    public StoreSportUporovContext()
    {
    }

    public StoreSportUporovContext(DbContextOptions<StoreSportUporovContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Manufacture> Manufactures { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<OrdersHistory> OrdersHistories { get; set; }

    public virtual DbSet<PickUpPoint> PickUpPoints { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SportTovar> SportTovars { get; set; }

    public virtual DbSet<Suplier> Supliers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=store_sport_uporov;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_category_id");

            entity.ToTable("categories");

            entity.HasIndex(e => e.CategoryName, "categories_category_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName).HasColumnName("category_name");
        });

        modelBuilder.Entity<Manufacture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_manufactures_id");

            entity.ToTable("manufactures");

            entity.HasIndex(e => e.ManufacturesName, "manufactures_manufactures_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ManufacturesName).HasColumnName("manufactures_name");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_statuses_id");

            entity.ToTable("order_statuses");

            entity.HasIndex(e => e.StatusName, "order_statuses_status_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName)
                .HasMaxLength(50)
                .HasColumnName("status_name");
        });

        modelBuilder.Entity<OrdersHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_orders_history_id");

            entity.ToTable("orders_history");

            entity.HasIndex(e => e.Code, "orders_history_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.IdPickUpPoint).HasColumnName("id_pick_up_point");
            entity.Property(e => e.IdUser)
                .HasMaxLength(250)
                .HasColumnName("id_user");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .HasColumnName("order_status");

            entity.HasOne(d => d.PickUpPoint).WithMany(p => p.OrdersHistories)
                .HasForeignKey(d => d.IdPickUpPoint)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_orders_history_to_pick_up_points");

            entity.HasOne(d => d.User).WithMany(p => p.OrdersHistories)
                .HasPrincipalKey(p => p.UserFio)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_orders_history_to_users");

            entity.HasOne(d => d.OrderStatusNavigation).WithMany(p => p.OrdersHistories)
                .HasPrincipalKey(p => p.StatusName)
                .HasForeignKey(d => d.OrderStatus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_orders_history_to_order_statuses");
        });

        modelBuilder.Entity<PickUpPoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_pick_up_points_id");

            entity.ToTable("pick_up_points");

            entity.HasIndex(e => e.Address, "pick_up_points_adress_key").IsUnique();

            entity.HasIndex(e => e.PhoneNumber, "pick_up_points_phone_number_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_roles_id");

            entity.ToTable("roles");

            entity.HasIndex(e => e.RoleName, "roles_role_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(250)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<SportTovar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_sport_tovars_id");

            entity.ToTable("sport_tovars");

            entity.HasIndex(e => e.Article, "sport_tovars_article_key").IsUnique();

            entity.HasIndex(e => e.Description, "sport_tovars_description_key").IsUnique();

            entity.HasIndex(e => e.Price, "sport_tovars_price_key").IsUnique();

            entity.HasIndex(e => e.TovarName, "sport_tovars_tovar_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.IdManufacture).HasColumnName("id_manufacture");
            entity.Property(e => e.IdSupliers).HasColumnName("id_supliers");
            entity.Property(e => e.Photo).HasColumnName("photo");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.QuantityInStock).HasColumnName("quantity_in_stock");
            entity.Property(e => e.TovarName).HasColumnName("tovar_name");
            entity.Property(e => e.UnitOfMeasurement)
                .HasMaxLength(10)
                .HasColumnName("unit_of_measurement");

            entity.HasOne(d => d.Category).WithMany(p => p.SportTovars)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_sport_tovars_to_categories");

            entity.HasOne(d => d.Manufacture).WithMany(p => p.SportTovars)
                .HasForeignKey(d => d.IdManufacture)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_sport_tovars_to_manufactures");

            entity.HasOne(d => d.Suplier).WithMany(p => p.SportTovars)
                .HasForeignKey(d => d.IdSupliers)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_sport_tovars_to_supliers");
        });

        modelBuilder.Entity<Suplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_supliers_id");

            entity.ToTable("supliers");

            entity.HasIndex(e => e.SupliersName, "supliers_supliers_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SupliersName).HasColumnName("supliers_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_users_id");

            entity.ToTable("users");

            entity.HasIndex(e => e.UserFio, "users_user_fio_key").IsUnique();

            entity.HasIndex(e => e.Login, "users_user_login_key").IsUnique();

            entity.HasIndex(e => e.Password, "users_user_password_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.UserFio)
                .HasMaxLength(250)
                .HasColumnName("user_fio");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("fk_users_to_roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
