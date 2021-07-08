using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Controllers
{
    public class TenantsController : Controller
    {
        // GET: TenantsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TenantsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TenantsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TenantsController/Create
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

        // GET: TenantsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TenantsController/Edit/5
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

        // GET: TenantsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TenantsController/Delete/5
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
