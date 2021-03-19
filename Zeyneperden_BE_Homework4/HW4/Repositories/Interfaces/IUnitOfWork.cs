using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW4.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICarRepository Cars { get; }
        IBrandRepository Brands { get; }
        Task<int> CommitAsync();
    }
}
