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

        public override List<Post> GetAll()
        {
            var postsXr = _context.Posts
                .Include(p => p.Yer)
                    .ThenInclude(y=>y.Parent)
                    //.ThenInclude(y=>y.YerChilds)
                .ToList();

            return postsXr;
        }

        public override Post GetById(int id)
        {
            var post = _context.Posts
                            .Where(p => p.Id == id)
                            .Include(y => y.Yer)
                                .ThenInclude(y => y.Posts)
                            .Include(y => y.Yer)
                                .ThenInclude(y=>y.YerChilds)
                            //.Include(y => y.Comments)
                            //.Include(y => y.Ratings)
                            //.Include(y => y.Tags)
                            .FirstOrDefault();
            return post;
        }

        public override void Create(Post post)
        {
            post.Yer = _context.Yers.Find(post.YerId);
            post.DateCreated = DateTime.Now;
            base.Create(post);
        }
    }
}
