using Microsoft.EntityFrameworkCore;
using Sistem.Core.Abstract.DalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.EfCoreDal
{
    public class EfCoreDalRepository<T/*, TContext*/> : IDalRepository<T>
        where T : class
        //where TContext : DbContext, new()
    {
        private EfCoreSistemContext _context;
        public EfCoreDalRepository(EfCoreSistemContext context)
        {
            _context = context;
        }
        public virtual List<T> GetAll()
        {
            var ts = _context.Set<T>().ToList();
            return ts;
        }

        public virtual T GetById(int id)
        {
            var t = _context.Set<T>().Find(id);
            return t;
        }
    }
}
