using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using Sistem.WebUI.Areas.Admin.Models;
using Sistem.WebUI.Controllers;
using Sistem.WebUI.Models;

namespace Sistem.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YerController : DefaultController<Yer>
    {
        private IServiceYer _yerService;
        public YerController(IServiceRepository<Yer> tService, IServiceYer yerService) : base(tService)
        {
            _yerService = yerService;
        }
        public override ActionResult Index()
        {
            var yerListModel = new YerListVM()
            {
                Yerler = _yerService.GetAll()
            };
            return View(yerListModel);
        }
    }
}