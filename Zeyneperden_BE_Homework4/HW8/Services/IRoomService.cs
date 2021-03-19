using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW8.Models.Derived;

namespace HW8.Services
{
    public interface IRoomService
    {
        Task<List<Room>> GetRoomAsync();

        Task<Room> GetRoomAsync(Guid id);
    }
}
