using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5_Core;
using HW5_Core.Repositories;
using HW5_Data.Contexts;
using HW5_Data.Repositories;

namespace HW5_Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private BookRepository _bookRepository;
        private TopicRepository _topicRepository;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IBookRepository Books => _bookRepository = _bookRepository ?? new BookRepository(_context);

        public ITopicRepository Topics => _topicRepository = _topicRepository ?? new TopicRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
