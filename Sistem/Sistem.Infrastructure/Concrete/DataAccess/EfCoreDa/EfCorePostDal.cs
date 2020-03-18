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

        public int GetPostCountByYer(string yer)
        {
            var posts = _context.Posts.AsQueryable();

            if (!string.IsNullOrEmpty(yer))
            {
                posts.Include(p=>p.Yer).Any(a => a.Yer.Title.ToLower() == yer.ToLower());
            }

            return posts.Count();
        }
    }
}
