using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5_Core.Models;
using HW5_Core.Repositories;
using HW5_Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace HW5_Data.Repositories
{
    public class TopicRepository : RepositoryBase<Topic>, ITopicRepository
    {
        public TopicRepository(DatabaseContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Topic>> GetAllWithBooksAsync()
        {
            return await DatabaseContext.Topics.Include(t => t.Books).ToListAsync();
        }

        public Task<Topic> GetWithBooksByIdAsync(int id)
        {
            return DatabaseContext.Topics.Include(t => t.Books).SingleOrDefaultAsync(t => t.Id == id);
        }

        private DatabaseContext DatabaseContext
        {
            get { return _context as DatabaseContext; }
        }
    }
}
