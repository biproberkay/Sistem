using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using Sistem.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistem.WebUI.Areas.Blog.ViewComponents 
{
    public class YerListViewComponent : ViewComponent
    {
        private IServiceYer _yerService;
        public YerListViewComponent(IServiceYer yerService) 
        {
            _yerService = yerService;
        }
        public IViewComponentResult Invoke(int yerId)
        {
            var model = new YerListVM()
            {
                SelectedYer = _yerService.GetById(yerId),
                Yerler = _yerService.GetAll()
            };
            return View(model);
        }
        

    }
}
