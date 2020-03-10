using Sistem.Core.Abstract.DaInterfaces;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.Managers
{
    public class PostManager : ManagerRepository<Post>, IPostService
    {
        private IPostDal _postDal;

        public PostManager(IPostDal postDal , IDaRepository<Post> da) : base(da)
        {
            _postDal = postDal;
        }

        public Post GetPostDetails(int id)
        {
            return _postDal.GetPostDetails(id);
        }
    }
}
