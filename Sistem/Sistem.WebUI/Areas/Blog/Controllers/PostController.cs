using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            ViewData["YerId"] = new SelectList(_serviceYer.GetAll(), "Id", "Title", yerId);
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,Summary,Body,DateCreated,DateModified,YerId")] Post post)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(post);
                _postService.Create(post);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["YerId"] = new SelectList(_serviceYer.GetAll(), "Id", "Title", post.YerId);
            return View(post);
        }

    }
}