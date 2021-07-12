using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Service;

namespace TantosHousingProject.Controllers
{
    public class ContractsController : Controller
    {
        private readonly IContractService _contractService;

        public ContractsController(IContractService contractService)
        {
            _contractService = contractService;
        }


        // GET: ContractsController
        public ActionResult ContractIndex()
        {
            return View(_contractService.All());
        }

        // GET: ContractsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContractsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContractsController/Create
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

        // GET: ContractsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContractsController/Edit/5
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

        // GET: ContractsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContractsController/Delete/5
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
