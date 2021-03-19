using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW5_Core.Models;
using HW5_Core.Repositories;
using HW5_Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace HW5_Data.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(DatabaseContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Book>> GetAllWithTopicAsync()
        {
            return await DatabaseContext.Books.Include(b => b.Topic).ToListAsync();
        }

        public  async Task<IEnumerable<Book>> GetAllWithTopicByArtistIdAsync(int topicId)
        {
            return await DatabaseContext.Books.Include(b => b.Topic).Where(b => b.TopicId == topicId).ToListAsync();
        }

        public async Task<Book> GetWithTopicByIdAsync(int id)
        {
            return await DatabaseContext.Books.Include(b => b.Topic)
                .SingleOrDefaultAsync(b => b.Id == id);
        }

        private DatabaseContext DatabaseContext
        {
            get { return _context as DatabaseContext; }
        }
    }
}
