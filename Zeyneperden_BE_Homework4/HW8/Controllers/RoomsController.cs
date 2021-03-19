using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW8.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW8.Controllers
{
    [Authorize]
    [Route("/[controller]")]
    [ApiController]
    //[ApiVersion("1.1")]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet(Name = nameof(GetRooms))]
        public async Task<IActionResult> GetRooms()
        {
            var rooms = await _roomService.GetRoomAsync();
            if (rooms == null)
            {
                return NoContent();
            }
            return Ok(rooms);
        }


        //private readonly HotelApiDbContext _dbContext;

        //public RoomsController(HotelApiDbContext context)
        //{
        //    _dbContext = context;
        //}

        //[HttpGet(Name = nameof(GetRooms))]
        //public IActionResult GetRooms()
        //{
        //    var rooms = _dbContext.Rooms.ToList();
        //    return rooms;
        //}
    }
}
