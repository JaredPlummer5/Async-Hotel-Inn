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
using Microsoft.AspNetCore.Authorization;

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
        [Authorize(Roles = "DistrictManager")]
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
        [Authorize(Roles = "DistrictManager")]
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
        [HttpPut]
        [Authorize(Roles = "DistrictManager,PropertyManager")]
        [Route("{roomId}/Amenity/{amenityId}")]
        public async Task<IActionResult> UpdateRoomAmenities(int roomId, int amenityId, [FromBody] RoomAmenity updateRoomAmenity)
        {
            // Check if the room and amenity exist
            var room = await _context.Rooms.FindAsync(roomId);
            var amenity = await _context.Amenitites.FindAsync(amenityId);

            if (room == null || amenity == null)
            {
                return NotFound();
            }

            // Check if the amenity already exists for the room
            var roomAmenity = await _context.RoomAmenities
                .FirstOrDefaultAsync(ra => ra.RoomId == roomId && ra.AmenityID == amenityId);

            if (roomAmenity == null)
            {
                // If the room does not have the amenity, add it
                roomAmenity = new RoomAmenity
                {
                    RoomId = roomId,
                    AmenityID = amenityId
                };

                _context.RoomAmenities.Add(roomAmenity);
            }
            else
            {
                // If the room already has the amenity, you can update any additional properties if needed.
                // For example: roomAmenity.SomeProperty = someValue;
                roomAmenity.Amenity = updateRoomAmenity.Amenity;
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw; // Handle the exception as you see fit
            }


            return Ok(room);
        }



        // POST: api/Rooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "DistrictManager")]
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
        [Authorize(Roles = "DistrictManager,PropertyManager")]
        [Route("{roomId}/Amenity/{amenityId}")]
        public async Task<IActionResult> PostAmenityToRoom(int roomID, int amenityID)
        {
          


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
        [Authorize(Roles = "DistrictManager")]
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
        [Authorize(Roles = "DistrictManager,Agent")]
        [Route("{roomId}/Amenity/{amenityId}")]
        public async Task<IActionResult> DeleteRoom(int amenityID, int roomID)
        {

          
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
