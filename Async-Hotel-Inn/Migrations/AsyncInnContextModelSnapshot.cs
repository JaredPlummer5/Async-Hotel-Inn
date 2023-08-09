﻿// <auto-generated />
using Async_Hotel_Inn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Async_Hotel_Inn.Migrations
{
    [DbContext(typeof(AsyncInnContext))]
    partial class AsyncInnContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
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
