using Sistem.Core.Abstract.DalInterfaces;
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

        public PostManager(IPostDal postDal , IDalRepository<Post> dal) : base(dal)
        {
            _postDal = postDal;
        }

    }
}
