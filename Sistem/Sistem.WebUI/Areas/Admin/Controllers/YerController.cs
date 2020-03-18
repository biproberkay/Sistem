using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;
using Sistem.Core.Entities;
using Sistem.WebUI.Controllers;

namespace Sistem.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YerController : DefaultController<Yer>
    {
        public YerController(IServiceRepository<Yer> tService) : base(tService)
        {
        }
    }
}