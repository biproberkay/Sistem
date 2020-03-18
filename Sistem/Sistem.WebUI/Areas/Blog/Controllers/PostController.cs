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
            _tService = tService;
            _postService = postService;
        }

        public ActionResult IndexWithPagination(string yer, int page = 1)
        {
            const int pageSize = 3;
            var model = new PostListModel();
            model.PagingInfo = new PagingInfo()
            {
                ItemsPerPage = pageSize,
                CurrentPlace = yer,
                CurrentPage = page,
                TotalItems = _postService.GetAll().Count()
            };

            return View();
        }

        public override ActionResult Details(int id)
        {
            return base.Details(id);
        }

        public ActionResult PostOku(int id)
        {
            var post = _postService.GetPostDetails(id);
            var postModel = new PostVM()
            {
                Post = post
                /*
                Body = post.Body,
                Title = post.Title,
                Summary = post.Summary,
                DateCreated = post.DateCreated,
                DateModified = post.DateModified,
                Id = post.Id,
                Yer = post.Yer,
                YerId = post.YerId
                */
            };
            return View(postModel);
        }
    }
}