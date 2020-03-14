using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using Sistem.WebUI.Areas.Blog.Models;
using Sistem.WebUI.Controllers;

namespace Sistem.WebUI.Areas.Blog.Controllers 
{
    [Area("Blog")]
    public class PostController : DefaultController<Post>
    {
        //private IPostService _postService;
        private IServiceRepository<Post> _postService;
        public PostController(IServiceRepository<Post> tService) : base(tService)
        {
            _postService = tService;
        }

        public ActionResult Index(string yer, int page = 1)
        {
            const int pageSize = 3;
            var model = new PostListModel();
            model.PagingInfo = new PagingInfo()
            {
                ItemsPerPage = pageSize,
                CurrentPlace = yer,
                CurrentPage = page,
                TotalItems = _postService.get
            }
            return View();
        }

    }
}