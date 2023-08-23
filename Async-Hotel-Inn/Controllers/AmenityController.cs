using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Async_Hotel_Inn.Data;
using Async_Hotel_Inn.Models;
using Microsoft.AspNetCore.Authorization;

namespace Async_Hotel_Inn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AmenityController : ControllerBase
    {
        private readonly AsyncInnContext _context;

        public AmenityController(AsyncInnContext context)
        {
            _context = context;
        }

        // GET: api/Amenity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amenity>>> GetAmenitites()
        {
          if (_context.Amenitites == null)
          {
              return NotFound();
          }
            return await _context.Amenitites.ToListAsync();
        }

        // GET: api/Amenity/5
        [HttpGet("{id}")]

        [Authorize(Roles = "DistrictManager,PropertyManager,Agent")]

        public async Task<ActionResult<Amenity>> GetAmenity(int id)
        {
          if (_context.Amenitites == null)
          {
              return NotFound();
          }
            var amenity = await _context.Amenitites.FindAsync(id);

            if (amenity == null)
            {
                return NotFound();
            }

            return amenity;
        }

        // PUT: api/Amenity/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "DistrictManager,PropertyManager")]


        public async Task<IActionResult> PutAmenity(int id, Amenity amenity)
        {
            if (id != amenity.ID)
            {
                return BadRequest();
            }

            _context.Entry(amenity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmenityExists(id))
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

        // POST: api/Amenity
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "DistrictManager,PropertyManager")]

        public async Task<ActionResult<Amenity>> PostAmenity(Amenity amenity)
        {
          if (_context.Amenitites == null)
          {
              return Problem("Entity set 'AsyncInnContext.Amenitites'  is null.");
          }
            _context.Amenitites.Add(amenity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAmenity", new { id = amenity.ID }, amenity);
        }

        // DELETE: api/Amenity/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "DistrictManager")]

        public async Task<IActionResult> DeleteAmenity(int id)
        {
            if (_context.Amenitites == null)
            {
                return NotFound();
            }
            var amenity = await _context.Amenitites.FindAsync(id);
            if (amenity == null)
            {
                return NotFound();
            }

            _context.Amenitites.Remove(amenity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AmenityExists(int id)
        {
            return (_context.Amenitites?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
