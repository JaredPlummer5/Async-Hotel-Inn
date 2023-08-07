using System;
using Async_Inn_Hotel_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Async_Hotel_Inn.Models.Interfaces
{
	public interface IHotel
	{
        public  Task<ActionResult<IEnumerable<HotelClass>>> GetHotels();

        public  Task<ActionResult<HotelClass>> GetHotelClass(int id);

        public  Task<IActionResult> PutHotelClass(int id, HotelClass hotelClass);

        public  Task<ActionResult<HotelClass>> PostHotelClass(HotelClass hotelClass);

        public  Task<IActionResult> DeleteHotelClass(int id);

        public  bool HotelClassExists(int id);

    }
}

