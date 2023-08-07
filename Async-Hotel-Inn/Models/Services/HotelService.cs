using System;
using Async_Hotel_Inn.Data;
using Async_Hotel_Inn.Models.Interfaces;
using Async_Inn_Hotel_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Async_Hotel_Inn.Models.Services
{
	public class HotelService : IHotel
	{
        private AsyncInnContext _context;


        public HotelService(AsyncInnContext context)
		{
            _context = context;
		}



        public async Task<ActionResult<HotelClass>> GetHotelClass(int id)
        {
           return await _context.Hotels.FindAsync(id);
        }





        public async Task<ActionResult<IEnumerable<HotelClass>>> GetHotels()
        {

            //if (_context.Hotels == null)
            //{
            //    return NotFound();
            //}
            return await _context.Hotels.ToListAsync();
        }





        public  bool HotelClassExists(int id)
        {
           return  (_context.Hotels?.Any(e => e.ID == id)).GetValueOrDefault();
        }





        public async Task<ActionResult<HotelClass>> PostHotelClass(HotelClass hotelClass)
        {
            _context.Hotels.Add(hotelClass);
            await _context.SaveChangesAsync();
            return hotelClass;
        }





        public async Task<IActionResult> PutHotelClass(int id, HotelClass hotelClass)
        {
            _context.Entry(hotelClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
               
                throw;
                
            }

            return null;
        }




        public async Task<IActionResult> DeleteHotelClass(int id)
        {
            var hotelClass = await _context.Hotels.FindAsync(id);
            _context.Hotels.Remove(hotelClass);
            await _context.SaveChangesAsync();
            return null;

        }
    }
}

