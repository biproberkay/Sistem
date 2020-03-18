using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Abstract.DalInterfaces 
{
    public interface IDalRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
    }
}
