using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Async_Hotel_Inn.Data;
using Async_Inn_Hotel_Management_System.Models;

namespace Async_Hotel_Inn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly AsyncInnContext _context;

        public HotelsController(AsyncInnContext context)
        {
            _context = context;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelClass>>> GetHotels()
        {
          if (_context.Hotels == null)
          {
              return NotFound();
          }
            return await _context.Hotels.ToListAsync();
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelClass>> GetHotelClass(int id)
        {
          if (_context.Hotels == null)
          {
              return NotFound();
          }
            var hotelClass = await _context.Hotels.FindAsync(id);

            if (hotelClass == null)
            {
                return NotFound();
            }

            return hotelClass;
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

            _context.Entry(hotelClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelClassExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

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
            _context.Hotels.Add(hotelClass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotelClass", new { id = hotelClass.ID }, hotelClass);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelClass(int id)
        {
            if (_context.Hotels == null)
            {
                return NotFound();
            }
            var hotelClass = await _context.Hotels.FindAsync(id);
            if (hotelClass == null)
            {
                return NotFound();
            }

            _context.Hotels.Remove(hotelClass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelClassExists(int id)
        {
            return (_context.Hotels?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
