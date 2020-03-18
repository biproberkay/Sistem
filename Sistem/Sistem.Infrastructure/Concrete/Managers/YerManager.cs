using Sistem.Core.Abstract.DaInterfaces;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.Managers
{
    public class YerManager : ManagerRepository<Yer>, IServiceYer
    {
        private IDaYer _yerDa;

        public YerManager(IDaYer yerDa , IDaRepository<Yer> da) : base(da)
        {
            _yerDa = yerDa;
        }

        public Yer GetYerDetails(int id)
        {
            return _yerDa.GetYerDetails(id);
        }
    }
}
