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
    [Migration("20231215123026_ProducAndPaymentDescription")]
    partial class ProducAndPaymentDescription
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
                            ConcurrencyStamp = "ddb4e651-4ab5-40bc-8d1e-8541d06a96c8",
                            Email = "admin1@yah.com",
                            EmailConfirmed = true,
                            FirstName = "user",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@YAH.COM",
                            NormalizedUserName = "ADMIN1@YAH.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAySrL3+2X5IcxlSEGyp6TMF3shI0IgAQjISJ5Hgdd8opzKv+zNrsxLa9q6MowIaeA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "71d5d4e7-a555-4e8e-8297-df70fea798cc",
                            TwoFactorEnabled = false,
                            UserName = "admin1@yah.com"
                        },
                        new
                        {
                            Id = "43cb8c89-9172-46b6-aa72-f2e7bc12cf49",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bf142485-cb7c-4d1d-bd3c-197b5fcb40ad",
                            Email = "admin1@yahoo.com",
                            EmailConfirmed = true,
                            FirstName = "user",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@YAHOO.COM",
                            NormalizedUserName = "ADMIN1@YAHOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBJvgYEcGQ4OHLXRK6mmcKHQa8fRtNP5+ZsBe+SHdV/U6HKEcu8r7Y39ZMwqAOScsQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "41c7f4d7-0823-4847-837b-dd1e3ebbeea3",
                            TwoFactorEnabled = false,
                            UserName = "admin1@yahoo.com"
                        },
                        new
                        {
                            Id = "63cb8c98-1927-46b6-aa72-d2e7bc12cf49",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bf4b8c99-d1bb-48ee-a534-4af4cc25c135",
                            Email = "admin1@hoo.com",
                            EmailConfirmed = true,
                            FirstName = "user",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN1@HOO.COM",
                            NormalizedUserName = "ADMIN1@HOO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGscvVaGK+eUoy5nG0wDNY9uZhHqYSEGBpBCzAR+6VASaVpP8RkR/MhyKyqu7naUVg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5c2680ff-fe5b-4789-97c0-f3047a1f40f5",
                            TwoFactorEnabled = false,
                            UserName = "admin1@hoo.com"
                        },
                        new
                        {
                            Id = "d6a02c66-abf0-4fab-a98e-468080ee51df",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5d42b759-707e-49f2-a694-36db3c438a1d",
                            Email = "mar@user.com",
                            EmailConfirmed = true,
                            FirstName = "Mar",
                            LastName = "user",
                            LockoutEnabled = false,
                            NormalizedEmail = "MAR@USER.COM",
                            NormalizedUserName = "MAR@USER.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFwh3bgNlXoHWN0Ev/uC3Qqa2hyvNZhXB69wHq315oYnVF9GpjgcZvsuADrSQuxk1g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2eae5742-a318-4ffc-bada-d5e9ef47dc21",
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
                            ConcurrencyStamp = "960ecde4-5c2e-40de-8454-8641f92b12f4",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "c6a02c66-bbf0-4fab-a98e-468181ee51de",
                            ConcurrencyStamp = "35c1969b-b77b-4d40-9cba-f23070cded4f",
                            Name = "System",
                            NormalizedName = "SYSTEM"
                        },
                        new
                        {
                            Id = "b6a02c66-acf0-4fab-a98e-467080ee51df",
                            ConcurrencyStamp = "7be779dc-d3fa-402f-9816-4b2ca40118b2",
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
                            UserId = "d6a02c66-abf0-4fab-a98e-468080ee51df",
                            RoleId = "b6a02c66-acf0-4fab-a98e-467080ee51df"
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