using System;
using System.ComponentModel.DataAnnotations;

namespace Async_Inn_Hotel_Management_System.Models
{
	public class HotelClass
	{

		[Key]
		public int ID { get; set; }
		[Required]
		public string Name { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]

        public string City { get; set; }
        [Required]

        public string State { get; set; }
        [Required]

        public string PhoneNumber { get; set; }

    }
}

