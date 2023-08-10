using System;
using System.Reflection.Emit;
using Async_Hotel_Inn.Models;
using Async_Inn_Hotel_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Async_Hotel_Inn.Data
{
    public class AsyncInnContext : DbContext
    {
        public DbSet<Amenity> Amenitites { get; set; }
        public DbSet<RoomAmenity> RoomAmenities { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<HotelClass> Hotels { get; set; }

        public AsyncInnContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            //Information tables
            modelBuilder.Entity<Room>().HasData(new Room
            { ID = 1, Layout = 0, Name = "Basic Room" });

            modelBuilder.Entity<HotelClass>().HasData(new HotelClass
            {
                ID = 1,
                Address = "123 Sesame St",
                City = "Memphis",
                State = "TN",
                Name = "Memphis Inn",
                PhoneNumber = "901-222-2222"
            });

            modelBuilder.Entity<Amenity>().HasData(new Amenity
            { ID = 1, Name = "A/C" });

            // Reference Tables
            modelBuilder.Entity<RoomAmenity>().HasData(new RoomAmenity
            { ID = 1, AmenityID = 1, RoomId = 1 });
            modelBuilder.Entity<HotelRoom>().HasData(new HotelRoom
            { ID = 1, HotelID = 1, Name = "Jared's Hotel", RoomID = 1, Price = 120.99 });


            modelBuilder.Entity<Room>().HasData(new Room
            { ID = 2, Layout = 0, Name = "Basic Room" });

            modelBuilder.Entity<HotelClass>().HasData(new HotelClass
            {
                ID = 2,
                Address = "13 Sesamljkhe St",
                City = "Mej2jmphis",
                State = "TN",
                Name = "Memphis Inn",
                PhoneNumber = "901-222-2222"
            });

            modelBuilder.Entity<Amenity>().HasData(new Amenity
            { ID = 2, Name = "A/C" });

            // Reference Tables
            modelBuilder.Entity<RoomAmenity>().HasData(new RoomAmenity
            { ID = 2, AmenityID = 2, RoomId = 2 });
            modelBuilder.Entity<HotelRoom>().HasData(new HotelRoom
            { ID = 2, HotelID = 2, Name = "Jared's Hotel", RoomID = 2, Price = 120.99 });
            //base.OnModelCreating(modelBuilder)
        }
    }
}

