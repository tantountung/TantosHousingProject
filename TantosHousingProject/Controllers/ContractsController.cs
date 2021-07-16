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
        public ActionResult Details(int id)//no view for now since details has
                                           //no purpose, unless RFI for payment history
                                           //(payment is multiple so can be made to many
                                           //with one is contract)
        {
            Contract contract = _contractService.FindById(id);

            if (contract == null)
            {
                return RedirectToAction(nameof(ContractIndex));
            }

            return View(contract);
        }


        [HttpGet]
        public IActionResult EditContract(int id)
        {
            Contract contract = _contractService.FindById(id);

            if (contract == null)
            {
                return RedirectToAction("ContractIndex");
            }

            EditContractViewModel editContract = new EditContractViewModel();
            editContract.Id = id;
            editContract.CreateContract = _contractService.ContractToCreateContract(contract);

            return View(editContract);
        }

        [HttpPost]
        public IActionResult EditContract(int id, CreateContractViewModel createContract)
        {
            if (ModelState.IsValid)
            {
                Contract contract = _contractService.Edit(id, createContract);

                return RedirectToAction(nameof(ContractIndex));
            }

            EditContractViewModel editContract = new EditContractViewModel();
            editContract.Id = id;
            editContract.CreateContract = createContract;

            return View(editContract);
        }

        // GET: ContractsController/Delete/5
        public ActionResult Delete(int id)//RFI to delete
                                          //(so far, no delete for all controllers)
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
