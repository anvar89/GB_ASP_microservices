using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.Controllers
{
    public class CpuMetricsController : Controller
    {
        // GET: CpuMetricsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CpuMetricsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CpuMetricsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CpuMetricsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CpuMetricsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CpuMetricsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CpuMetricsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CpuMetricsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
