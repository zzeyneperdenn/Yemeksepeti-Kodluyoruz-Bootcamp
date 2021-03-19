using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5_Core.Models;
using HW5_Core.Repositories;

namespace HW5_Core.Repositories
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        Task<IEnumerable<Book>> GetAllWithTopicAsync();
        Task<Book> GetWithTopicByIdAsync(int id);
        Task<IEnumerable<Book>> GetAllWithTopicByArtistIdAsync(int topicId);
    }
}
