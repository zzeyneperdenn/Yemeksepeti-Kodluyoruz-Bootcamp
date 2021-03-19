using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5.Core.Repositories;

namespace HW5.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        ITopicRepository Topics { get; }
        Task<int> CommitAsync();
    }
}
