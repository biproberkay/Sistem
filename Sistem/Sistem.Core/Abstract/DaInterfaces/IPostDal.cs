using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Core.Abstract.DaInterfaces
{
    public interface IPostDal : IDaRepository<Post>
    {
        public Yer GetPostCountByYer(string yer); 
    }
}
