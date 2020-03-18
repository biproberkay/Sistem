using Sistem.Core.Abstract.DaInterfaces;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.MemoryDa
{
    public class MemoryDaRepository<T> : IDaRepository<T>
        where T :class, new()
    {
        List<T> ts = new List<T>()
        {
            new T(){},
            new T(){},
            new T(){},
        };

        public virtual List<T> GetAll()
        {
            return ts;
        }

        public virtual T GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
