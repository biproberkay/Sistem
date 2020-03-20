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
        private IPostService _postService;
        private IServiceRepository<Post> _tService;
        public PostController(IServiceRepository<Post> tService, IPostService postService) : base(tService)
        {
            _postService = postService;
            _tService = tService;
        }

        public ActionResult IndexWP(int yerId, int page = 1)
        {
            const int pageSize = 2;
            var model = new PostListModel
            {
                PagingInfo = new PagingInfo()
                {
                    ItemsPerPage = pageSize,
                    CurrentYerId = yerId,
                    CurrentPage = page,
                    TotalItems = _tService.GetAll().Where(p=>p.YerId==yerId).Count()
                },
                Posts = _tService.GetAll().Where(p=>p.YerId == yerId)
                    .Skip((page - 1) * pageSize).Take(pageSize).ToList()
            };

            return View(model);
        }

        public override ActionResult Details(int id)
        {
            var post = _postService.GetById(id);
            var postModel = new PostVM()
            {
                Post = post
            };
            return View(postModel);
        }

    }
}