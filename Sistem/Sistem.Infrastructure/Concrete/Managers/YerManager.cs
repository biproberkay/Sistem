using Sistem.Core.Abstract.DalInterfaces;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.Managers
{
    public class YerManager : ManagerRepository<Yer>, IYerService
    {
        private IYerDal _yerDal;

        public YerManager(IYerDal yerDal , IDalRepository<Yer> dal) : base(dal)
        {
            _yerDal = yerDal;
        }

        public Yer GetYerDetails(int id)
        {
            return _yerDal.GetYerDetails(id);
        }
    }
}
