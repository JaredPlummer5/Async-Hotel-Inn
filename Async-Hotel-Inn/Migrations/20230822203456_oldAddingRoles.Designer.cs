﻿// <auto-generated />
using System;
using Async_Hotel_Inn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Async_Hotel_Inn.Migrations
{
    [DbContext(typeof(AsyncInnContext))]
    [Migration("20230822203456_oldAddingRoles")]
    partial class oldAddingRoles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Async_Hotel_Inn.Models.Amenity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Amenitites");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "A/C"
                        },
                        new
                        {
                            ID = 2,
                            Name = "A/C"
                        });
                });

            modelBuilder.Entity("Async_Hotel_Inn.Models.ApplicationUser", b =>
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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            Id = "DistrictManager-id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "349b55c2-b79b-4740-8d89-9a442ef9505a",
                            Email = "DISTRICTMANAGER@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "DISTRICTMANAGER@EXAMPLE.COM",
                            NormalizedUserName = "DISTRICTMANAGER",
                            Password = "Password123!",
                            PasswordHash = "AQAAAAIAAYagAAAAECQOynrBZHJ6uaHqc5vWIcksuiOUJeeyH2VkeFuGxkKScgErHYWnXknxnU0KataA6Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "48a321cc-633a-4661-8c4b-97fee5175c5e",
                            TwoFactorEnabled = false,
                            UserName = "DistrictManager"
                        },
                        new
                        {
                            Id = "PropertyManager-id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c5323aba-69a8-4ccd-8f41-976a42e209b2",
                            Email = "PROPERTYMANAGER@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "PROPERTYMANAGER@EXAMPLE.COM",
                            NormalizedUserName = "PROPERTYMANAGER",
                            Password = "Password123!",
                            PasswordHash = "AQAAAAIAAYagAAAAEKXHq70H2R9dyzPUTVUX5tEqzoR91fIEGv4kSen11wOQbJ6bG+qosZCYkr+NT9o8xw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2e99aba4-7a43-4fd7-8efd-b29e431135c2",
                            TwoFactorEnabled = false,
                            UserName = "PropertyManager"
                        },
                        new
                        {
                            Id = "Agent-id",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4fad3747-624c-4fb0-b059-be083f1e5164",
                            Email = "AGENT@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "AGENT@EXAMPLE.COM",
                            NormalizedUserName = "AGENT",
                            Password = "Password123!",
                            PasswordHash = "AQAAAAIAAYagAAAAEKb/HJ1IymBsCBRfWtwVrScBr9ew7+qUEB7l1Fn6cSNzliDSTzVsZhoeX1TlVsFLQg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a39195da-523d-4526-b888-d43cacb3453a",
                            TwoFactorEnabled = false,
                            UserName = "Agent"
                        });
                });

            modelBuilder.Entity("Async_Hotel_Inn.Models.RoomAmenity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AmenityID")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AmenityID");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomAmenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AmenityID = 1,
                            RoomId = 1
                        },
                        new
                        {
                            ID = 2,
                            AmenityID = 2,
                            RoomId = 2
                        });
                });

            modelBuilder.Entity("Async_Inn_Hotel_Management_System.Models.HotelClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "123 Sesame St",
                            City = "Memphis",
                            Name = "Memphis Inn",
                            PhoneNumber = "901-222-2222",
                            State = "TN"
                        },
                        new
                        {
                            ID = 2,
                            Address = "13 Sesamljkhe St",
                            City = "Mej2jmphis",
                            Name = "Memphis Inn",
                            PhoneNumber = "901-222-2222",
                            State = "TN"
                        });
                });

            modelBuilder.Entity("Async_Inn_Hotel_Management_System.Models.HotelRoom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HotelID");

                    b.HasIndex("RoomID");

                    b.ToTable("HotelRooms");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            HotelID = 1,
                            Name = "Jared's Hotel",
                            Price = 120.98999999999999,
                            RoomID = 1
                        },
                        new
                        {
                            ID = 2,
                            HotelID = 2,
                            Name = "Jared's Hotel",
                            Price = 120.98999999999999,
                            RoomID = 2
                        });
                });

            modelBuilder.Entity("Async_Inn_Hotel_Management_System.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Layout")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Layout = 0,
                            Name = "Basic Room"
                        },
                        new
                        {
                            ID = 2,
                            Layout = 0,
                            Name = "Basic Room"
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
                            Id = "admin",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "editor",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "districtmanager",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "DistrictManager",
                            NormalizedName = "DISTRICTMANAGER"
                        },
                        new
                        {
                            Id = "propertymanager",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "PropertyManager",
                            NormalizedName = "PROPERTYMANAGER"
                        },
                        new
                        {
                            Id = "agent",
                            ConcurrencyStamp = "00000000-0000-0000-0000-000000000000",
                            Name = "Agent",
                            NormalizedName = "AGENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.HasData(
                        new
                        {
                            Id = 15,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "admin"
                        },
                        new
                        {
                            Id = 16,
                            ClaimType = "permissions",
                            ClaimValue = "update",
                            RoleId = "admin"
                        },
                        new
                        {
                            Id = 17,
                            ClaimType = "permissions",
                            ClaimValue = "delete",
                            RoleId = "admin"
                        },
                        new
                        {
                            Id = 18,
                            ClaimType = "permissions",
                            ClaimValue = "read",
                            RoleId = "admin"
                        },
                        new
                        {
                            Id = 19,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "editor"
                        },
                        new
                        {
                            Id = 20,
                            ClaimType = "permissions",
                            ClaimValue = "update",
                            RoleId = "editor"
                        },
                        new
                        {
                            Id = 21,
                            ClaimType = "permissions",
                            ClaimValue = "create",
                            RoleId = "districtmanager"
                        },
                        new
                        {
                            Id = 22,
                            ClaimType = "permissions",
                            ClaimValue = "update",
                            RoleId = "districtmanager"
                        },
                        new
                        {
                            Id = 23,
                            ClaimType = "permissions",
                            ClaimValue = "delete",
                            RoleId = "districtmanager"
                        },
                        new
                        {
                            Id = 24,
                            ClaimType = "permissions",
                            ClaimValue = "read",
                            RoleId = "districtmanager"
                        },
                        new
                        {
                            Id = 25,
                            ClaimType = "permissions",
                            ClaimValue = "update",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 26,
                            ClaimType = "permissions",
                            ClaimValue = "read",
                            RoleId = "propertymanager"
                        },
                        new
                        {
                            Id = 27,
                            ClaimType = "permissions",
                            ClaimValue = "update",
                            RoleId = "agent"
                        },
                        new
                        {
                            Id = 28,
                            ClaimType = "permissions",
                            ClaimValue = "read",
                            RoleId = "agent"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                            UserId = "DistrictManager-id",
                            RoleId = "DistrictManager"
                        },
                        new
                        {
                            UserId = "PropertyManager-id",
                            RoleId = "PropertyManager"
                        },
                        new
                        {
                            UserId = "Agent-id",
                            RoleId = "Agent"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Async_Hotel_Inn.Models.RoomAmenity", b =>
                {
                    b.HasOne("Async_Hotel_Inn.Models.Amenity", "Amenity")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("AmenityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Async_Inn_Hotel_Management_System.Models.Room", "Room")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenity");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Async_Inn_Hotel_Management_System.Models.HotelRoom", b =>
                {
                    b.HasOne("Async_Inn_Hotel_Management_System.Models.HotelClass", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Async_Inn_Hotel_Management_System.Models.Room", "Room")
                        .WithMany("HotelRooms")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");

                    b.Navigation("Room");
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
                    b.HasOne("Async_Hotel_Inn.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Async_Hotel_Inn.Models.ApplicationUser", null)
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

                    b.HasOne("Async_Hotel_Inn.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Async_Hotel_Inn.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Async_Hotel_Inn.Models.Amenity", b =>
                {
                    b.Navigation("RoomAmenities");
                });

            modelBuilder.Entity("Async_Inn_Hotel_Management_System.Models.Room", b =>
                {
                    b.Navigation("HotelRooms");

                    b.Navigation("RoomAmenities");
                });
#pragma warning restore 612, 618
        }
    }
}