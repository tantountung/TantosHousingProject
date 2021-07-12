using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Service;
using TantosHousingProject.Models.ViewModel;

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

        // GET: ContractsController/Create
        public ActionResult CreateContract()
        {
            return View();
        }

        // POST: ContractsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateContract(CreateContractViewModel createContract)
        {
            if (ModelState.IsValid)
            {
                _contractService.Add(createContract);
                return RedirectToAction(nameof(ContractIndex));
            }
            else
            {
                return View(createContract);
            }
        }

        // GET: ContractsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
