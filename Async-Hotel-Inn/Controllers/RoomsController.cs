using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Async_Hotel_Inn.Data;
using Async_Inn_Hotel_Management_System.Models;
using Async_Hotel_Inn.Models;

namespace Async_Hotel_Inn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly AsyncInnContext _context;

        public RoomsController(AsyncInnContext context)
        {
            _context = context;
        }

        // GET: api/Rooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        {
          if (_context.Rooms == null)
          {
              return NotFound();
          }
            return await _context.Rooms.Include(room => room.HotelRooms).ThenInclude(hotelRoom => hotelRoom.Hotel).Include(room => room.RoomAmenities)
                          .ThenInclude(roomAmenities => roomAmenities.Amenity).ToListAsync();
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
          if (_context.Rooms == null)
          {
              return NotFound();
          }
            var room = await _context.Rooms.FindAsync(id);

            if (room == null)
            {
                return NotFound();
            }

            return room;
        }

        // PUT: api/Rooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            if (id != room.ID)
            {
                return BadRequest();
            }

            _context.Entry(room).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(id))
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

        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
          if (_context.Rooms == null)
          {
              return Problem("Entity set 'AsyncInnContext.Rooms'  is null.");
          }
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync(); 

            return CreatedAtAction("GetRoom", new { id = room.ID }, room);
        }

        [HttpPost]
        [Route("{roomId}/Amenity/{amenityId}")]
        public async Task<IActionResult> PostAmenityToRoom(int roomID, int amenityID)
        {
            if (!(HttpContext.Request.Headers["UserEmail"].ToString().Split("AG")[0] == "AD") || !(HttpContext.Request.Headers["UserEmail"].ToString().Split("AG")[0] == "AG"))
            {
                return NoContent();
            }


            if (_context.RoomAmenities == null)
            {
                return Problem("Entity set 'AsyncInnContext.Amenities'  is null.");
            }


            var amenity = await _context.Amenitites.FindAsync(amenityID);
            if (amenity == null)
            {
                return Problem("No amenity with that ID exists");
            }

            var room = await _context.Rooms.FindAsync(roomID);
            if (room == null)
            {
                return Problem("No room with that ID exists");
            }

            RoomAmenity newRoomAmenity = new RoomAmenity();
            try
            {
                newRoomAmenity = _context.RoomAmenities.Add(new RoomAmenity { AmenityID = amenityID, RoomId = roomID }).Entity;
            }
            catch (Exception e)
            {
                // Handle exception as needed
            }
            finally
            {
                await _context.SaveChangesAsync();
            }

            return CreatedAtAction("PostAmenityToRoom", newRoomAmenity.ID, newRoomAmenity);


        }
        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            if (_context.Rooms == null)
            {
                return NotFound();
            }
            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        [Route("{roomId}/Amenity/{amenityId}")]
        public async Task<IActionResult> DeleteRoom(int amenityID, int roomID)
        {

            if (!(HttpContext.Request.Headers["UserEmail"] == "jaredplummer19@gmail.com") || !(HttpContext.Request.Headers["UserEmail"] == "agent@gmail.com"))
            {
                return NoContent();
            }
            if (_context.RoomAmenities == null)
            {
                return Problem("Enity set 'AsyncInnContext.Amenity'  is null.");
            }

            var amenity = _context.Amenitites.FindAsync(amenityID);
            if (amenity == null)
            {
                return Problem("No amenity with that ID Exists");
            }
            var room = _context.Rooms.FindAsync(roomID);
            if (room == null)
            {
                return Problem("No room with that ID exits");

            }

            try
            {
                RoomAmenity oldRA = await _context.RoomAmenities.FindAsync(new { AmenityID = amenityID, RoomID = roomID });
                _context.RoomAmenities.Remove(oldRA);
            }

            catch (Exception ex)
            {

            }
            finally
            {
                await _context.SaveChangesAsync();
            }
            return Ok();

        }

        private bool RoomExists(int id)
        {
            return (_context.Rooms?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
