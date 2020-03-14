using Microsoft.EntityFrameworkCore;
using Sistem.Core.Abstract.DaInterfaces;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.EfCoreDa
{
    public class EfCorePostDal : EfCoreDaRepository<Post>, IPostDal
    {
        private EfCoreSistemContext _context;
        public EfCorePostDal(EfCoreSistemContext context) : base(context)
        {
            _context = context;
        }

        public Post GetPostDetails(int id)
        {
            var t = _context.Posts
                            .Where(y => y.Id == id)
                            .Include(y => y.Yer)
                            //.Include(y => y.Comments)
                            //.Include(y => y.Ratings)
                            //.Include(y => y.Tags)
                            .FirstOrDefault();
            return t;
        }

        public override List<Post> GetAll()
        {
            var yerler = _context.Posts
                .Include(y => y.Yer).ToList();

            return base.GetAll();
        }

        public Yer GetPostCountByYer(int id)
        {
            var t = _context.Posts
                            .Where(y => y.YerId == id)
                            .Include(y => y.Yer)
                            //.Include(y => y.Comments)
                            //.Include(y => y.Ratings)
                            //.Include(y => y.Tags)
                            .FirstOrDefault();
            return t;
        }
    }
}
