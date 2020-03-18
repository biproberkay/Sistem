using Sistem.Core.Abstract.DalInterfaces;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.MemoryDal
{
    public class MemoryDalRepository<T> : IDalRepository<T> 
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
