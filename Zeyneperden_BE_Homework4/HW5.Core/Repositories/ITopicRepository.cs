using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5.Core.Models;

namespace HW5.Core.Repositories
{
    public interface ITopicRepository : IRepositoryBase<Topic>
    {
        Task<IEnumerable<Topic>> GetAllWithBooksAsync();
        Task<Topic> GetWithBooksByIdAsync(int id);
    }
}
