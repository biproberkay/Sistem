using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;

namespace Sistem.WebUI.Controllers
{
    public class IndexController : Controller
    {
        private IServiceRepository<Yer> _yerService;
        //private IServiceRepository<Post> _postService;

        public IndexController(IServiceRepository<Yer> yerService /*IServiceRepository<post>*/)
        {
            _yerService = yerService;
        }
        public IActionResult YerIndex()
        {
            return View(_yerService.GetAll());
        }
        public IActionResult PostIndex() 
        {
            return View();
        }
        public IActionResult TagIndex()
        {
            return View();
        }
        public IActionResult CommentIndex()
        {
            return View();
        }
    }
} 