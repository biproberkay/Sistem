using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Abstract.DaInterfaces
{
    public interface IDaRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T t);
    }
}
