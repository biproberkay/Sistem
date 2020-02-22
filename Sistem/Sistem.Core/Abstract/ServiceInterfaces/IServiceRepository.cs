using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Abstract.ServiceInterfaces
{
    public interface IServiceRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
    }
}
