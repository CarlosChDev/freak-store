﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using freak_store.Data;

#nullable disable

namespace freak_store.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241002164504_MigracionInicial")]
    partial class MigracionInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("freak_store.Models.AdminType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("admin_id")
                        .HasColumnType("integer");

                    b.Property<string>("permissions")
                        .IsRequired()
                        .HasColumnType("json");

                    b.HasKey("Id");

                    b.HasIndex("admin_id")
                        .IsUnique();

                    b.ToTable("admin_type");
                });

            modelBuilder.Entity("freak_store.Models.Admins", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("freak_store.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("freak_store.Models.Discounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("discounts");
                });

            modelBuilder.Entity("freak_store.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("inventory");
                });

            modelBuilder.Entity("freak_store.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("UserAddressId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("payment_id")
                        .HasColumnType("integer");

                    b.Property<int>("total_amount")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("user_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserAddressId");

                    b.HasIndex("payment_id")
                        .IsUnique();

                    b.ToTable("order_details");
                });

            modelBuilder.Entity("freak_store.Models.OrderItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("order_id")
                        .HasColumnType("integer");

                    b.Property<int?>("product_id")
                        .HasColumnType("integer");

                    b.Property<int?>("quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("order_id");

                    b.HasIndex("product_id")
                        .IsUnique();

                    b.ToTable("order_items");
                });

            modelBuilder.Entity("freak_store.Models.PaymentDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("order_id")
                        .HasColumnType("integer");

                    b.Property<string>("provider")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<int?>("total_amount")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("payment_details");
                });

            modelBuilder.Entity("freak_store.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<short>("Price")
                        .HasColumnType("smallint");

                    b.Property<int>("category_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("discount_id")
                        .HasColumnType("integer");

                    b.Property<string>("img")
                        .HasColumnType("text");

                    b.Property<int>("inventory_id")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sku")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("category_id");

                    b.HasIndex("discount_id");

                    b.HasIndex("inventory_id")
                        .IsUnique();

                    b.ToTable("products");
                });

            modelBuilder.Entity("freak_store.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("deleted_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("phone")
                        .HasColumnType("integer");

                    b.Property<DateTime>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("freak_store.Models.UserAddresses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("address_line1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("address_line2")
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("postal_code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("user_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("user_addresses");
                });

            modelBuilder.Entity("freak_store.Models.UserPayments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("account_number")
                        .HasColumnType("integer");

                    b.Property<DateTime>("create_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("payment_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("provider")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("user_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("user_id");

                    b.ToTable("user_payments");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("freak_store.Models.AdminType", b =>
                {
                    b.HasOne("freak_store.Models.Admins", "Admin")
                        .WithOne("AdminType")
                        .HasForeignKey("freak_store.Models.AdminType", "admin_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("freak_store.Models.OrderDetails", b =>
                {
                    b.HasOne("freak_store.Models.UserAddresses", "UserAddress")
                        .WithMany()
                        .HasForeignKey("UserAddressId");

                    b.HasOne("freak_store.Models.PaymentDetails", "PaymentDetail")
                        .WithOne("OrderDetail")
                        .HasForeignKey("freak_store.Models.OrderDetails", "payment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentDetail");

                    b.Navigation("UserAddress");
                });

            modelBuilder.Entity("freak_store.Models.OrderItems", b =>
                {
                    b.HasOne("freak_store.Models.OrderDetails", "OrderDetail")
                        .WithMany("OrderItems")
                        .HasForeignKey("order_id");

                    b.HasOne("freak_store.Models.Products", "Product")
                        .WithOne("OrderItem")
                        .HasForeignKey("freak_store.Models.OrderItems", "product_id");

                    b.Navigation("OrderDetail");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("freak_store.Models.Products", b =>
                {
                    b.HasOne("freak_store.Models.Categories", "Category")
                        .WithMany("Products")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("freak_store.Models.Discounts", "Discount")
                        .WithMany("Products")
                        .HasForeignKey("discount_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("freak_store.Models.Inventory", "Inventory")
                        .WithOne("Product")
                        .HasForeignKey("freak_store.Models.Products", "inventory_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Discount");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("freak_store.Models.UserAddresses", b =>
                {
                    b.HasOne("freak_store.Models.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("freak_store.Models.UserPayments", b =>
                {
                    b.HasOne("freak_store.Models.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("freak_store.Models.Admins", b =>
                {
                    b.Navigation("AdminType");
                });

            modelBuilder.Entity("freak_store.Models.Categories", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("freak_store.Models.Discounts", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("freak_store.Models.Inventory", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("freak_store.Models.OrderDetails", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("freak_store.Models.PaymentDetails", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("freak_store.Models.Products", b =>
                {
                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("freak_store.Models.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
