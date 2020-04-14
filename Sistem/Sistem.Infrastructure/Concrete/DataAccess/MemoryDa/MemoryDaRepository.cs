using Sistem.Core.Abstract.DaInterfaces;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.MemoryDa
{
    public class MemoryDaRepository<T> : IDaRepository<T>
    {
        public void Create(T t)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}
