using Sistem.Core.Abstract.DaInterfaces;
using Sistem.Core.Abstract.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.Managers
{
    public class ManagerRepository<T> : IServiceRepository<T> where T : class
    {
        private IDaRepository<T> _da;

        public ManagerRepository(IDaRepository<T> da)
        {
            _da = da;
        }
        public List<T> GetAll()
        {
            return _da.GetAll();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
