using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Abstract.DaInterfaces
{
    public interface IDaYer : IDaRepository<Yer>
    {
        public Yer GetYerDetails(int id);
    }
}
