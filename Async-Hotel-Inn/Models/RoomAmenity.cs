using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Async_Hotel_Inn.Models
{
	public class RoomAmenity
	{
		[Key]
		public int ID { get; set; }
        [Required]

        public int RoomId { get; set; }
        [Required]

        public int AmenityID { get; set; }


    }
}

