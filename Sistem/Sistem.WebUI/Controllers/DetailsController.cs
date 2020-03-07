using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using Sistem.WebUI.Areas.Member.Models;

namespace Sistem.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class DetailsController : Controller
    {

        //private IServiceRepository<Yer> _yerService;
        private IServiceYer _yerServiceMore;
        //private IServiceRepository<Post> _postService;

        public DetailsController(
            //IServiceRepository<Yer> yerService,
            IServiceYer yerServiceMore
            //,
            //IServiceRepository<Post> postService
            )
        {
            //_yerService = yerService;
            _yerServiceMore = yerServiceMore;
            //_postService = postService;
        }
        public IActionResult DetailsYer(int? id)
        { 
            if (id==null)
            {
                return NotFound();
            }
            var yer = _yerServiceMore.GetById((int)id);
            //var yerModel = new YerVM()
            //{
            //    Id = yer.Id,
            //    Level = yer.Level,
            //    ParentId = yer.ParentId,
            //    Title = yer.Title,
            //};
            return View(yer);
        }
        public IActionResult DetailsYerMore(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var yer = _yerServiceMore.GetYerDetails((int)id);
            var yerModel = new YerVM()
            {
                Id = yer.Id,
                Level = yer.Level,
                ParentId = yer.ParentId,
                Parent = yer.Parent,
                Title = yer.Title,
                Posts = yer.Posts.ToList(),
                YerChilds = yer.YerChilds.ToList()
            };
            return View(yerModel);
        }
    }
}