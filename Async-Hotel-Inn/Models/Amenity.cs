using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Async_Hotel_Inn.Models
{
	public class Amenity
	{
        [Required]

        public string Name { get; set; }
		[Key]
		public int ID { get; set; }
	}
}

