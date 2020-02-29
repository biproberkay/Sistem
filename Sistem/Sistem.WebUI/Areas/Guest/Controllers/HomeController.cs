﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistem.WebUI.Areas.Guest.Controllers
{
    [Area("Guest")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}