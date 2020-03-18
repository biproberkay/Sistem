using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistem.Core.Abstract.ServiceInterfaces;

namespace Sistem.WebUI.Controllers
{
    public class MediaLogController<T> : Controller 
        where T : class
    {
        private IServiceRepository<T> _tService;

        public MediaLogController(IServiceRepository<T> tService)
        {
            _tService = tService;
        }
        // GET: MediaLog
        public ActionResult Index()
        {
            var ts = _tService.GetAll();
            return View(ts);
        }

        // GET: MediaLog/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MediaLog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MediaLog/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MediaLog/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MediaLog/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MediaLog/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MediaLog/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}