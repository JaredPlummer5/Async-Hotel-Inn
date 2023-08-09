using System;
using System.ComponentModel.DataAnnotations;
using Async_Hotel_Inn.Models;

namespace Async_Inn_Hotel_Management_System.Models
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public int Layout { get; set; }

        public List<HotelRoom>? HotelRooms { get; set; }

        public List<RoomAmenity>? RoomAmenities { get; set; }
    }
}
