using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5.Core;
using HW5.Core.Repositories;
using HW5.Data.Contexts;
using HW5.Data.Repositories;

namespace HW5.Data
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
