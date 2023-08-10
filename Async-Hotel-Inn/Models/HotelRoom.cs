using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Async_Inn_Hotel_Management_System.Models
{
	public class HotelRoom
	{
        [Key]
        public int ID { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required]

        public int HotelID { get; set; }
        [Required]

        public double Price { get; set; }
        [Required]

        public int RoomID { get; set; }

        public HotelClass? Hotel { get; set; }

        public Room? Room { get; set; }
    }
}

