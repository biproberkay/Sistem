using Microsoft.EntityFrameworkCore;
using Sistem.Core.Abstract.DaInterfaces;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.EfCoreDa
{
    public class EfCoreYerDa : EfCoreDaRepository<Yer>, IDaYer
    {
        private EfCoreSistemContext _context;
        public EfCoreYerDa(EfCoreSistemContext context) : base(context)
        {
            _context = context;
        }

        public Yer GetYerDetails(int id)
        {
            var t = _context.Yers
                            .Where(y => y.Id == id)
                            .Include(y => y.Parent)
                            .Include(y => y.Posts)
                            .Include(y => y.YerChilds)
                            .FirstOrDefault();
            return t;
        }
    }
}
