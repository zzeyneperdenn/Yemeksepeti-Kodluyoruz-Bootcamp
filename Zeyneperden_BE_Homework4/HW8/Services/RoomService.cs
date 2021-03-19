using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HW8.Contexts;
using HW8.Models.Derived;
using Microsoft.EntityFrameworkCore;

namespace HW8.Services
{
    public class RoomService : IRoomService
    {
        private readonly HotelApiDbContext _dbContext;
        private readonly IMapper _mapper;

        public RoomService(HotelApiDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<Room>> GetRoomAsync()
        {
            var roomEntities = await _dbContext.Rooms.ToListAsync();
            var result = roomEntities.Select(room => _mapper.Map<Room>(room)).ToList();
            return result;
        }

        public async Task<Room> GetRoomAsync(Guid id)
        {
            var roomEntity = await _dbContext.Rooms.SingleOrDefaultAsync(room => room.Id == id);
            if (roomEntity == null)
            {
                return null;
            }
            return _mapper.Map<Room>(roomEntity);
        }
    }
}
