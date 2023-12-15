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
    [Migration("20231215152432_SuperADminRoleANDSUPerAdmin")]
    partial class SuperADminRoleANDSUPerAdmin
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
                            ConcurrencyStamp = "6a0568a6-3a4f-4a69-b394-81992ed46592",
                            Email = "admin1@yah.com",
                            EmailConfirmed = true,
                            FirstName = "user",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@YAH.COM",
                            NormalizedUserName = "ADMIN1@YAH.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBNBGLaUW0DU0Hr6DRRM2WmfSIBkhMGOGauzcP9SMt+ss5sRyT2SpkRNaqrgvUf62Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "03348e13-5590-488c-bafe-92a34270624d",
                            TwoFactorEnabled = false,
                            UserName = "admin1@yah.com"
                        },
                        new
                        {
                            Id = "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ad77c664-2dc5-4913-b16c-44447de984f5",
                            Email = "admin1@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "user",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@YAHOO.COM",
                            NormalizedUserName = "ADMIN1@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEH402eJ0shA/jLye8Cd+vTKUs08DIx6qBjP4wSdf9J0WKibEufr8s6/hYO98d7FD6Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ee752eb2-dd8b-4bac-af02-20804f4b07a5",
                            TwoFactorEnabled = false,
                            UserName = "admin1@yahoo.com"
                        },
                        new
                        {
                            Id = "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "31d7216d-14c3-4a88-8ce0-488771dfeca9",
                            Email = "admin1@hoo.com",
                            EmailConfirmed = true,
                            FirstName = "user",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@HOO.COM",
                            NormalizedUserName = "ADMIN1@HOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELFatqzVvlRR5Hcj1AU6Mx31gdL3Rm6qelcGNqq94eT4858xFUDF6pQCFovPCTJZmQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8b2cd866-7b75-4e24-aec1-6d696086bafe",
                            TwoFactorEnabled = false,
                            UserName = "admin1@hoo.com"
                        },
                        new
                        {
                            Id = "d6a02c66-abf0-4fab-a98e-468080ee51df",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0e45db95-3e1a-4194-b2c1-189b885e804b",
                            Email = "mar@user.com",
                            EmailConfirmed = true,
                            FirstName = "Mar",
                            LastName = "user",
                            LockoutEnabled = false,
                            NormalizedEmail = "MAR@USER.COM",
                            NormalizedUserName = "MAR@USER.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDJpj0BLhjco92WZ7hkQIqfJ05FfyefyFRg1NmMMAIZl70ru8lk/9J0qkewoMG/4/Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2c0812cc-bca1-4f39-a43d-c30d32feb7fb",
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
                            ConcurrencyStamp = "7e232e5d-25b7-444a-a4a3-2b3fa1d3c6e5",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                            ConcurrencyStamp = "bdc803a1-d6cb-4992-b406-79e733004679",
                            Name = "System",
                            NormalizedName = "SYSTEM"
                        },
                        new
                        {
                            Id = "f4e166e1-363f-4f5e-a91d-b4b957c27cdc",
                            ConcurrencyStamp = "64551075-557c-4508-a4ae-132c9ee4aab7",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "b6a02c66-acf0-4fab-a98e-467080ee51df",
                            ConcurrencyStamp = "5266fa12-95ff-49f5-82e6-22eceaae740a",
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
