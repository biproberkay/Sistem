using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        private IServiceYer _serviceYer;
        private IPostService _postService;
        private IServiceRepository<Post> _tService;
        public PostController(IServiceRepository<Post> tService, IPostService postService, IServiceYer serviceYer) : base(tService)
        {
            _serviceYer = serviceYer;
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
                    .Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                YerId = yerId
            };

            return View(model);
        }

        public override ActionResult Details(int id)
        {
            var post = _postService.GetById(id);
            var postModel = new PostVM()
            {
                Postt = post
            };
            return View(postModel);
        }

        [HttpGet]
        public IActionResult Create(int yerId)
        {
            var model = new PostModel();
            model.Yer = _serviceYer.GetById(yerId);
            return View(model);
        }
        // POST: Default/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public override ActionResult Create(IFormCollection collection)
        {
            //if (!ModelState.IsValid) return View(viewModel);
            //var model = Activator.CreateInstance(PostModel);
            var model = new PostModel();
            Type modelType = model.GetType();

            foreach (PropertyInfo propertyInfo in modelType.GetProperties())
            {
                var mykey = propertyInfo.Name;
                if (propertyInfo.CanRead && collection.Keys.Contains(mykey))
                {
                    try
                    {
                        var value = collection[mykey];
                        propertyInfo.SetValue(model, value);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            Post post = new Post()
            {
                Title = model.Title,
                Summary = model.Summary,
                Body = model.Body,
                Yer = model.Yer

            };
            _postService.Create(post);
            
            return base.Create(collection);
        }

    }
}