using Microsoft.EntityFrameworkCore;
using Sistem.Core.Abstract.DalInterfaces;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.EfCoreDal
{
    public class EfCorePostDal : EfCoreDalRepository<Post>, IPostDal
    {
        private EfCoreSistemContext _context;
        public EfCorePostDal(EfCoreSistemContext context) : base(context)
        {
            _context = context;
        }

        public override Post GetById(int id)
        {
            var t = _context.Posts
                            .Where(p => p.Id == id)
                            .Include(y => y.Yer)
                                .ThenInclude(y => y.Posts)
                            .Include(y => y.Yer)
                                .ThenInclude(y=>y.YerChilds)
                            //.Include(y => y.Comments)
                            //.Include(y => y.Ratings)
                            //.Include(y => y.Tags)
                            .FirstOrDefault();
            return t;
        }

        public override List<Post> GetAll()
        {
            var postsWyer = _context.Posts
                .Include(p => p.Yer)
                    .ThenInclude(y=>y.Parent)
                    //.ThenInclude(y=>y.YerChilds)
                .ToList();

            return base.GetAll();
        }


    }
}
