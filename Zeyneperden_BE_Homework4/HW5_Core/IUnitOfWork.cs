using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HW5_Core.Repositories;

namespace HW5_Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        ITopicRepository Topics { get; }
        Task<int> CommitAsync();
    }
}
