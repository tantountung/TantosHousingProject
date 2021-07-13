using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Service;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Controllers
{
    public class ContractsController : Controller
    {
        private readonly IContractService _contractService;
        private readonly IRoomService roomService;
        private readonly ITenantService tenantService;

        public ContractsController(IContractService contractService, IRoomService roomService, ITenantService tenantService)
        {
            _contractService = contractService;
            this.roomService = roomService;
            this.tenantService = tenantService;
        }


        // GET: ContractsController
        public ActionResult ContractIndex()
        {
            return View(_contractService.All());
        }

        // GET: ContractsController/Create
        public ActionResult CreateContract()
        {
            CreateContractViewModel createContract = new CreateContractViewModel();
            createContract.RoomList = roomService.All().RoomList;
            createContract.TenantList = tenantService.All().TenantList;

            return View(createContract);
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
            Contract contract = _contractService.FindById(id);

            if (contract == null)
            {
                return RedirectToAction(nameof(ContractIndex));
            }

            return View(contract);
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
