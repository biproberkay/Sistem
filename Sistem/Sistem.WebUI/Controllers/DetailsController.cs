using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistem.WebUI.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult YerDetails(int id) 
        {
            return View();
        }
        public IActionResult PostDetails(int id)
        {
            return View();
        }
        public IActionResult TagDetails(int id)
        {
            return View();
        }
        public IActionResult CommentDetails(int id)
        {
            return View();
        }
        public IActionResult RatingDetails(int id)
        {
            return View();
        }
    }
}