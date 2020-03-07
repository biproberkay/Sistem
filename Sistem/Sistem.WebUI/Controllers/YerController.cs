using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;

namespace Sistem.WebUI.Controllers
{
    public class YerController : DefaultController<Yer>
    {
        public YerController(IServiceRepository<Yer> tService) : base(tService)
        {
        }
        public override ActionResult Index()
        {
            
            return base.Index();
        }
    }
}