using Microsoft.EntityFrameworkCore;
using Sistem.Core.Abstract.DalInterfaces;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.EfCoreDal
{
    public class EfCoreYerDal : EfCoreDalRepository<Yer>, IYerDal 
    {
        private EfCoreSistemContext _context;
        public EfCoreYerDal(EfCoreSistemContext context) : base(context)
        {
            _context = context;
        }

        public override List<Yer> GetAll()
        {
            var yerler = _context.Yers
                .Include(y => y.YerChilds).ToList();

            return yerler;
        }

        public override Yer GetById(int id)
        {
            var yer = _context.Yers
                            .Where(y => y.Id == id)
                            .Include(y => y.Parent)
                            .Include(y => y.Posts)
                            .Include(y => y.YerChilds)
                            .FirstOrDefault();
            return yer;
        }
    }
}
