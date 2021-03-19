using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5.Core.Models;
using HW5.Core.Repositories;

namespace HW5.Core.Repositories
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        Task<IEnumerable<Book>> GetAllWithTopicAsync();
        Task<Book> GetWithTopicByIdAsync(int id);
        Task<IEnumerable<Book>> GetAllWithTopicByArtistIdAsync(int topicId);
    }
}
