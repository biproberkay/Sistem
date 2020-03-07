using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using Sistem.WebUI.Models;

namespace Sistem.WebUI.Controllers
{
    public class ListController : Controller
    {
        private IServiceRepository<Yer> _yerService;
        private IServiceRepository<Post> _postService;

        public ListController(
            IServiceRepository<Yer> yerService
            , IServiceRepository<Post> postService
            )
        {
            _yerService = yerService;
            _postService = postService;
        }
        public IActionResult IndexPost()
        {
            var model = new ListVM()
            {
                Posts = _postService.GetAll()
            };
            return View(model);
        }

        public IActionResult IndexYer()
        {
            var model = new ListVM()
            {
                Yers = _yerService.GetAll()
            };
            return View(model);
        }
    }
}