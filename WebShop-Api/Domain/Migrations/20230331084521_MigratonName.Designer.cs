﻿// <auto-generated />
using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Domain.Migrations
{
    [DbContext(typeof(WebShopContext))]
    [Migration("20230331084521_MigratonName")]
    partial class MigratonName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProductCount")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CartId");

                    b.HasIndex("ProductsId");

                    b.HasIndex("UserId");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Domain.Models.DeliveryType", b =>
                {
                    b.Property<int>("DeliveryTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DeliveryTypeId");

                    b.ToTable("DeliveryType", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("DeliveryTypeId");

                    b.HasIndex("StatusId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("Domain.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemsId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("OrderItemsId")
                        .HasName("PK__OrderIte__D5BB255596F30BAC");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Domain.Models.Product", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,10)");

                    b.HasKey("ProductsId")
                        .HasName("PK__Products__BB48EDE5962634C1");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RoleId");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Specification", b =>
                {
                    b.Property<int>("SpecId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("SpecId")
                        .HasName("PK__Specific__883D567B5F355A69");

                    b.HasIndex("CategoryId");

                    b.ToTable("Specification", (string)null);
                });

            modelBuilder.Entity("Domain.Models.SpecProduct", b =>
                {
                    b.Property<int>("SpecProdId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int?>("SpecId")
                        .HasColumnType("int");

                    b.HasKey("SpecProdId")
                        .HasName("PK__Spec_Pro__BDDD4ED61BAFE61C");

                    b.HasIndex("ProductsId");

                    b.HasIndex("SpecId");

                    b.ToTable("Spec_Products", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("StatusId");

                    b.ToTable("Status", (string)null);
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Cart", b =>
                {
                    b.HasOne("Domain.Models.Product", "Products")
                        .WithMany("Carts")
                        .HasForeignKey("ProductsId")
                        .IsRequired()
                        .HasConstraintName("FK_Products_Cart");

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Cart_User1");

                    b.Navigation("Products");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Order", b =>
                {
                    b.HasOne("Domain.Models.DeliveryType", "DeliveryType")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_DeliveryType");

                    b.HasOne("Domain.Models.Status", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK_Orders_Statuses");

                    b.Navigation("DeliveryType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Domain.Models.OrderItem", b =>
                {
                    b.HasOne("Domain.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_item_Orders");

                    b.HasOne("Domain.Models.Product", "Products")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductsId")
                        .IsRequired()
                        .HasConstraintName("FK_Order_items_Products");

                    b.Navigation("Order");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Models.Product", b =>
                {
                    b.HasOne("Domain.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Products__Catego__4E88ABD4");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Models.Specification", b =>
                {
                    b.HasOne("Domain.Models.Category", "Category")
                        .WithMany("Specifications")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Specifica__Categ__5165187F");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Models.SpecProduct", b =>
                {
                    b.HasOne("Domain.Models.Product", "Products")
                        .WithMany("SpecProducts")
                        .HasForeignKey("ProductsId")
                        .HasConstraintName("FK__Spec_Prod__Produ__4F7CD00D");

                    b.HasOne("Domain.Models.Specification", "Spec")
                        .WithMany("SpecProducts")
                        .HasForeignKey("SpecId")
                        .HasConstraintName("FK__Spec_Prod__SpecI__5070F446");

                    b.Navigation("Products");

                    b.Navigation("Spec");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.HasOne("Domain.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK_Users_Roles");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Models.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Specifications");
                });

            modelBuilder.Entity("Domain.Models.DeliveryType", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Domain.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Domain.Models.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("OrderItems");

                    b.Navigation("SpecProducts");
                });

            modelBuilder.Entity("Domain.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Models.Specification", b =>
                {
                    b.Navigation("SpecProducts");
                });

            modelBuilder.Entity("Domain.Models.Status", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("Carts");
                });
#pragma warning restore 612, 618
        }
    }
}
