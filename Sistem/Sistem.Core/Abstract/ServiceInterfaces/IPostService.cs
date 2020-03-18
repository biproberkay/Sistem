using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Abstract.ServiceInterfaces
{
    public interface IPostService : IServiceRepository<Post>
    {
        public int GetPostCountByYer(string yer);
        public Post GetPostDetails(int id);
    }
}
