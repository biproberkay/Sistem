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
        public virtual List<T> GetAll()
        {
            var ts = new List<T>();
            ts.AddRange( new List<T>() { 
                new T(), new T(), new T(), 
            });
            return ts;
        }

        public virtual T GetById(int id)
        {
            var t = new T();
            return t;
        }

    }
}
