using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using Sistem.WebUI.Areas.Admin.Models;

namespace Sistem.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YerController : Controller
    {
        private IServiceRepository<Yer> _yerService;

        public YerController(IServiceRepository<Yer> yerService)
        {
            _yerService = yerService;
        }
        public IActionResult Index()
        {
            var model = new YerListViewModel()
            { 
                Yers = _yerService.GetAll()
            };
            return View(model);
        }

        public IActionResult Details(int? id)
        {
            Yer yer = _yerService.GetById((int)id);
            var model = new YerViewModel()
            {
                Id = yer.Id,
                Level = yer.Level,
                Title = yer.Title,
                ParentId = yer.ParentId
            };
            return View(model);
        }
    }
}