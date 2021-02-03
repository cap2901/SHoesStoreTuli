﻿// <auto-generated />
using System;
using CoV.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoV.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoV.DataAccess.Data.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.CategoryProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.ColorProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("ColorProduct");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<DateTime?>("CreateDate");

                    b.Property<DateTime?>("CreateUpdate");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PassWord");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.MakerProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MakerName");

                    b.HasKey("Id");

                    b.ToTable("MakerProduct");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Name");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("Size");

                    b.Property<int>("StatusId");

                    b.Property<int>("TotalPrice");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StatusId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.OrderDetals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("NameCustomer");

                    b.Property<string>("NameProduct");

                    b.Property<int>("NumberProduct");

                    b.Property<int>("PhoneNumber");

                    b.Property<string>("Shipper");

                    b.Property<int>("StatusId");

                    b.Property<int?>("StatusOrderId");

                    b.Property<int>("TotalMoney");

                    b.HasKey("Id");

                    b.HasIndex("StatusOrderId");

                    b.ToTable("OrderDetals");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarDetails");

                    b.Property<int>("CategoryProductId");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("FirstDate");

                    b.Property<int>("GenderProductId");

                    b.Property<int>("MakerProductId");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Price");

                    b.Property<int>("PriceNew");

                    b.Property<string>("Sku")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryProductId");

                    b.HasIndex("GenderProductId");

                    b.HasIndex("MakerProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.ProductDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarDetails");

                    b.Property<int>("NumberProduct");

                    b.Property<int>("ProductId");

                    b.Property<int>("SizeProduct");

                    b.Property<int>("StatusProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StatusProductId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.SizeProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SizeName");

                    b.HasKey("Id");

                    b.ToTable("SizeProduct");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.StatusOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("StatusOrder");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.StatusProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("StatusProduct");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ExpiredDate");

                    b.Property<DateTime?>("FirstDate");

                    b.Property<string>("ImageAvatar")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Request");

                    b.Property<int>("RoleId");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.Cart", b =>
                {
                    b.HasOne("CoV.DataAccess.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoV.DataAccess.Data.Order", b =>
                {
                    b.HasOne("CoV.DataAccess.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoV.DataAccess.Data.StatusOrder", "StatusOrder")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoV.DataAccess.Data.OrderDetals", b =>
                {
                    b.HasOne("CoV.DataAccess.Data.StatusOrder", "StatusOrder")
                        .WithMany()
                        .HasForeignKey("StatusOrderId");
                });

            modelBuilder.Entity("CoV.DataAccess.Data.Product", b =>
                {
                    b.HasOne("CoV.DataAccess.Data.CategoryProduct", "CategoryProduct")
                        .WithMany("CatogoryProducts")
                        .HasForeignKey("CategoryProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoV.DataAccess.Data.Gender", "Gender")
                        .WithMany("GenderProduct")
                        .HasForeignKey("GenderProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoV.DataAccess.Data.MakerProduct", "MakerProduct")
                        .WithMany("MakerProducts")
                        .HasForeignKey("MakerProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoV.DataAccess.Data.ProductDetails", b =>
                {
                    b.HasOne("CoV.DataAccess.Data.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoV.DataAccess.Data.StatusProduct", "StatusProduct")
                        .WithMany()
                        .HasForeignKey("StatusProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoV.DataAccess.Data.User", b =>
                {
                    b.HasOne("CoV.DataAccess.Data.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}