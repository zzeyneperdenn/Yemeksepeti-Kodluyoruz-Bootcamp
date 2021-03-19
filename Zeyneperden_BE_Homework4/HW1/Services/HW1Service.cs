using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW1.Services
{
    public class HW1Service : ISingletonService, ITransientService, IScopedService
    {
        Guid _id;
        public HW1Service()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return _id;
        }
    }

    public interface ISingletonService
    {
        Guid GetId();
    }

    public interface ITransientService
    {
        Guid GetId();
    }

    public interface IScopedService
    {
        Guid GetId();
    }
}
