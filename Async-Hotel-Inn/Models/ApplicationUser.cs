using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace Async_Hotel_Inn.Models
{
	public class ApplicationUser : IdentityUser
	{
		[Key]

		public string Id { get; set; }
		[Required]
		public string Username { get; set; }

		public string Password { get; set; }

		public string Email { get; set; }

		public string PhoneNumber { get; set; }
	}
	
}

