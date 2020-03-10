using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;

namespace Sistem.WebUI.Controllers
{
    public class PostController : DefaultController<Post>
    {
        public PostController(IServiceRepository<Post> tService) : base(tService)
        {
        }

    }
}