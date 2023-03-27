﻿// <auto-generated />
using System;
using Asm_PH26327.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asm_PH26327.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20230320180343_thang")]
    partial class Asm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Asm_PH26327.Models.BilDetail", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idHd")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("idSp")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("RoleId");

                    b.HasIndex("idHd");

                    b.HasIndex("idSp");

                    b.ToTable("BilDetails");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Bill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Hoadon", (string)null);
                });

            modelBuilder.Entity("Asm_PH26327.Models.Cart", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Decreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Asm_PH26327.Models.CartDetail", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("IdSp");

                    b.HasIndex("UserId");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Color", b =>
                {
                    b.Property<Guid>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Nsx", b =>
                {
                    b.Property<Guid>("NsxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.HasKey("NsxId");

                    b.ToTable("Nsxes");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nsx")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("NsxId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SizeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nchar(100)")
                        .IsFixedLength();

                    b.Property<int>("availabelQuantity")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ColorId");

                    b.HasIndex("NsxId");

                    b.HasIndex("SizeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Decreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Size", b =>
                {
                    b.Property<Guid>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaSize")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("Asm_PH26327.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.HasKey("UserId");

                    b.HasAlternateKey("Username");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Asm_PH26327.Models.BilDetail", b =>
                {
                    b.HasOne("Asm_PH26327.Models.Role", null)
                        .WithMany("BilDetail")
                        .HasForeignKey("RoleId");

                    b.HasOne("Asm_PH26327.Models.Bill", "Bill")
                        .WithMany("BilDetails")
                        .HasForeignKey("idHd")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HD");

                    b.HasOne("Asm_PH26327.Models.Product", "Product")
                        .WithMany("BilDetail")
                        .HasForeignKey("idSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SP");

                    b.Navigation("Bill");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Bill", b =>
                {
                    b.HasOne("Asm_PH26327.Models.User", "User")
                        .WithMany("Bill")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Cart", b =>
                {
                    b.HasOne("Asm_PH26327.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("Asm_PH26327.Models.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Asm_PH26327.Models.CartDetail", b =>
                {
                    b.HasOne("Asm_PH26327.Models.Product", "Product")
                        .WithMany("CartDetail")
                        .HasForeignKey("IdSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Asm_PH26327.Models.Cart", "Cart")
                        .WithMany("CartDetail")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Product", b =>
                {
                    b.HasOne("Asm_PH26327.Models.Color", null)
                        .WithMany("Product")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Asm_PH26327.Models.Nsx", null)
                        .WithMany("Product")
                        .HasForeignKey("NsxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Asm_PH26327.Models.Size", null)
                        .WithMany("Product")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Asm_PH26327.Models.User", b =>
                {
                    b.HasOne("Asm_PH26327.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Bill", b =>
                {
                    b.Navigation("BilDetails");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Cart", b =>
                {
                    b.Navigation("CartDetail");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Color", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Nsx", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Product", b =>
                {
                    b.Navigation("BilDetail");

                    b.Navigation("CartDetail");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Role", b =>
                {
                    b.Navigation("BilDetail");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Asm_PH26327.Models.Size", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Asm_PH26327.Models.User", b =>
                {
                    b.Navigation("Bill");

                    b.Navigation("Cart")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
