using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.MemoryDa
{
    public class MemoryPostDa : MemoryDaRepository<Post>
    {
        public override List<Post> GetAll()
        {

            var postlar = new List<Post>()
            {
                new Post{
                    Id=1, Title="Bilgisayar Programcılığı", 
                    Summary="Summary Summary Summary Summary Summary Summary Summary ",
                    Body = "Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> ",
                    ArticleDateCreated=DateTime.Now, ArticleDateModified=DateTime.UtcNow,
                },
                new Post{Id=2, Title="Yazılım",
                    Summary="Summary Summary Summary Summary Summary Summary Summary ",
                    Body = "Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> ",
                    ArticleDateCreated=DateTime.Now, ArticleDateModified=DateTime.UtcNow,
                },
                new Post{Id=3, Title="Donanım",
                    Summary="Summary Summary Summary Summary Summary Summary Summary ",
                    Body = "Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> ",
                    ArticleDateCreated=DateTime.Now, ArticleDateModified=DateTime.UtcNow,
                },
                new Post{Id=4, Title="Grafik",
                    Summary="Summary Summary Summary Summary Summary Summary Summary ",
                    Body = "Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> ",
                    ArticleDateCreated=DateTime.Now, ArticleDateModified=DateTime.UtcNow,
                }
            };
            return postlar;
        }

        public override Post GetById(int id)
        {
            var postlar = new List<Post>()
            {
                new Post{
                    Id=1, Title="Bilgisayar Programcılığı",
                    Summary="Summary Summary Summary Summary Summary Summary Summary ",
                    Body = "Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> ",
                    ArticleDateCreated=DateTime.Now, ArticleDateModified=DateTime.UtcNow,
                    YerId=1
                },
                new Post{Id=2, Title="Yazılım",
                    Summary="Summary Summary Summary Summary Summary Summary Summary ",
                    Body = "Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> ",
                    ArticleDateCreated=DateTime.Now, ArticleDateModified=DateTime.UtcNow,
                    YerId=1
                },
                new Post{Id=3, Title="Donanım",
                    Summary="Summary Summary Summary Summary Summary Summary Summary ",
                    Body = "Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> ",
                    ArticleDateCreated=DateTime.Now, ArticleDateModified=DateTime.UtcNow,
                    YerId=1
                },
                new Post{Id=4, Title="Grafik",
                    Summary="Summary Summary Summary Summary Summary Summary Summary ",
                    Body = "Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> Body Body Body Body Body Body Body Body Body Body Body Body Body </br> ",
                    ArticleDateCreated=DateTime.Now, ArticleDateModified=DateTime.UtcNow,
                    YerId=1
                }
            };
            return postlar.Find(y=>y.Id==id);
        }
    }
}
