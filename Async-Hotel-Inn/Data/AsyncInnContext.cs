using System;
using System.Reflection.Emit;
using Async_Hotel_Inn.Models;
using Async_Inn_Hotel_Management_System.Models;
using Microsoft.AspNetCore.Identity;
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
        public DbSet<ApplicationUser> Users { get; set; }
        //public DbSet<IdentityUserRole<string>> Roles { get; set; }

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
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
            //Adding Roles 
            
        }



        private int nextId = 1;

        private void SeedRole(ModelBuilder modelBuilder, string roleName, params string[] permissions)
        {
            var role = new IdentityRole
            {
                Id = roleName.ToLower(),
                Name = roleName,
                NormalizedName = roleName.ToUpper(),
                ConcurrencyStamp = Guid.Empty.ToString()
            };

            modelBuilder.Entity<IdentityRole>().HasData(role);

            // Go through the permissions list (the params) and seed a new entry for each
            var roleClaims = permissions.Select(permission =>
              new IdentityRoleClaim<string>
              {
                  Id = nextId++,
                  RoleId = role.Id,
                  ClaimType = "permissions", // This matches what we did in Startup.cs
                  ClaimValue = permission
              }).ToArray();

            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(roleClaims);
        }
    }
}

