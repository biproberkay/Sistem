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

        public override Post GetById(int id)
        {
            return _postDal.GetById(id);
        }
        public override List<Post> GetAll()
        {
            return _postDal.GetAll();
        }
        public override void Create(Post t)
        {
            _postDal.Create(t);
        }
    }
}
