using Sistem.Core.Abstract.DalInterfaces;
using Sistem.Core.Abstract.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.Managers
{
    public class ManagerRepository<T> : IServiceRepository<T> where T : class
    {
        private IDalRepository<T> _dal;

        public ManagerRepository(IDalRepository<T> dal)
        {
            _dal = dal;
        }
        public List<T> GetAll()
        {
            return _dal.GetAll();
        }

        public T GetById(int id)
        {
            return _dal.GetById(id);
        }
    }
}
