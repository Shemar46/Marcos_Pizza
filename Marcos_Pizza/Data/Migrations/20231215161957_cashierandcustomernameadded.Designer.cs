﻿// <auto-generated />
using System;
using Marcos_Pizza.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Marcos_Pizza.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231215161957_cashierandcustomernameadded")]
    partial class cashierandcustomernameadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Marcos_Pizza.Data.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Customer_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Datetime_Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Payment_Method")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Marcos_Pizza.Data.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Product_Code")
                        .HasColumnType("int");

                    b.Property<float>("Product_Cost")
                        .HasColumnType("real");

                    b.Property<string>("Product_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_IMG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Marcos_Pizza.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8368c828-3886-4333-9c7c-a863dae589ca",
                            Email = "admin1@yah.com",
                            EmailConfirmed = true,
                            FirstName = "user",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@YAH.COM",
                            NormalizedUserName = "ADMIN1@YAH.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECT1s+gXqIzmcHy4hGMmoTYaPdr7J/IyoH13RZHGZ35LFThvWKgjcOq/J0b3Ch6Pww==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "be99f890-1b5c-4a2b-9ecc-284e78793176",
                            TwoFactorEnabled = false,
                            UserName = "admin1@yah.com"
                        },
                        new
                        {
                            Id = "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a49397af-dde7-4472-b084-ad089b3e665a",
                            Email = "admin1@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "user",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@YAHOO.COM",
                            NormalizedUserName = "ADMIN1@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELhE3wCu1qAjh1YBhKUoCcj/PkOrVn9B9liD2/+V8OZYQitb9l5DVhKq8kaDfkwW8w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a1311390-ffa1-4737-9996-ae1111cd1e14",
                            TwoFactorEnabled = false,
                            UserName = "admin1@yahoo.com"
                        },
                        new
                        {
                            Id = "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "753b2e4b-497a-4421-a8f1-12936e0e54df",
                            Email = "admin1@hoo.com",
                            EmailConfirmed = true,
                            FirstName = "user",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@HOO.COM",
                            NormalizedUserName = "ADMIN1@HOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL+09qdKOS/UfUTS7ABry9Ag6wLtag8BAgu4tooQW3NKrMEX6xSWOPRuK7YZA8MFrg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ece25468-4d16-4c0d-9f3e-d598d7d686d8",
                            TwoFactorEnabled = false,
                            UserName = "admin1@hoo.com"
                        },
                        new
                        {
                            Id = "d6a02c66-abf0-4fab-a98e-468080ee51df",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d9f14e0a-e5c0-49f0-af2d-298b7bcb8ef9",
                            Email = "mar@user.com",
                            EmailConfirmed = true,
                            FirstName = "Mar",
                            LastName = "user",
                            LockoutEnabled = false,
                            NormalizedEmail = "MAR@USER.COM",
                            NormalizedUserName = "MAR@USER.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFooisH9+t9A9Fa7finIcTjIw4Eq5OKKGYVr5zAxdCgrS8y54W4tkTiZsDa9RavbrQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e9490552-5915-4ed1-913b-047c66530a92",
                            TwoFactorEnabled = false,
                            UserName = "mar@user.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "43cb8c89-9172-46b6-aa72-e2e7dc12cf49",
                            ConcurrencyStamp = "378e8dd4-1540-411d-b8f3-8821dd2ae07f",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                            ConcurrencyStamp = "9d4fb090-2366-4af5-83a3-c4f27f7d664b",
                            Name = "System",
                            NormalizedName = "SYSTEM"
                        },
                        new
                        {
                            Id = "f4e166e1-363f-4f5e-a91d-b4b957c27cdc",
                            ConcurrencyStamp = "42ef0a8f-089e-4994-add2-8e951392af98",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "b6a02c66-acf0-4fab-a98e-467080ee51df",
                            ConcurrencyStamp = "0018a775-48cb-492e-9d1f-4afd4de50887",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                            RoleId = "43cb8c89-9172-46b6-aa72-e2e7dc12cf49"
                        },
                        new
                        {
                            UserId = "e9b43ab8-ad6b-4a8e-949c-a4d14312c1ca",
                            RoleId = "c6a02c66-bbf0-4fab-a98e-468181ee51de"
                        },
                        new
                        {
                            UserId = "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                            RoleId = "c6a02c66-bbf0-4fab-a98e-468181ee51de"
                        },
                        new
                        {
                            UserId = "f4e155e1-363f-4f5e-a91d-a4a957c27cdc",
                            RoleId = "f4e166e1-363f-4f5e-a91d-b4b957c27cdc"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
                    b.HasOne("Marcos_Pizza.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Marcos_Pizza.Data.User", null)
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

                    b.HasOne("Marcos_Pizza.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Marcos_Pizza.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
