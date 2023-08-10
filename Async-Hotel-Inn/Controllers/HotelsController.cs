using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Async_Hotel_Inn.Data;
using Async_Inn_Hotel_Management_System.Models;
using Async_Hotel_Inn.Models.Interfaces;

namespace Async_Hotel_Inn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly AsyncInnContext _context;
        private readonly IHotel _hotel;

        public HotelsController(AsyncInnContext context, IHotel hotel)
        {
            _context = context;
            _hotel = hotel;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelClass>>> GetHotels()
        {

            return await _hotel.GetHotels();
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelClass>> GetHotelClass(int id)
        {

            return await _hotel.GetHotelClass(id);
          //if (_context.Hotels == null)
          //{
          //    return NotFound();
          //}
          //  var hotelClass = await _context.Hotels.FindAsync(id);

          //  if (hotelClass == null)
          //  {
          //      return NotFound();
          //  }

          //  return hotelClass;
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotelClass(int id, HotelClass hotelClass)
        {
            if (id != hotelClass.ID)
            {
                return BadRequest();
            }

            await _hotel.PutHotelClass(id, hotelClass);

            return NoContent();
        }

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelClass>> PostHotelClass(HotelClass hotelClass)
        {
          if (_context.Hotels == null)
          {
              return Problem("Entity set 'AsyncInnContext.Hotels'  is null.");
          }
           await _hotel.PostHotelClass(hotelClass);

            return CreatedAtAction("GetHotelClass", new { id = hotelClass.ID }, hotelClass);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelClass(int id)
        {
            _hotel.DeleteHotelClass(id);
         
            return NoContent();
        }

        [HttpGet]
        [Route("/api/Hotels/{hotelId}/Rooms")]
        public async Task<ActionResult<IEnumerable<HotelRoom>>> GetAllRoomsForHotelAsync(int hotelId)
        {
            if (hotelId == 0)
            {
                return NotFound();
            }
            var hotelRoom = await _context.HotelRooms.Where(hr => hr.HotelID == hotelId).ToListAsync();

            return hotelRoom;
            /* List<HotelRoom> rooms = await _context.HotelRooms.Where(hr => hr.HotelID == hotelId).ToListAsync();
             return Ok(rooms);*/
        }

 

        private bool HotelClassExists(int id)
        {
            return _hotel.HotelClassExists(id);
        }
    }
}
