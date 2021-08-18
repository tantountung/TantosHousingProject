using Microsoft.AspNetCore.Authorization;
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
    
    public class HousekeepersController : Controller
    {
        private readonly IHousekeeperService _housekeeperService;

        public HousekeepersController(IHousekeeperService housekeeperService)
        {
            _housekeeperService = housekeeperService;
        }


       public IActionResult HousekeeperIndex()
        {
            return View(_housekeeperService.All());
        }

        [HttpPost]
        public IActionResult HousekeeperIndex(HousekeeperIndexViewModel vm)
        {
            vm.HousekeeperList = _housekeeperService.FindByHousekeeperName(vm.FilterText);

            return View(vm);
        }

        [HttpGet]
        public IActionResult CreateHousekeeper()
        {
            return View(new CreateHousekeeperViewModel());
        }
       
        [HttpPost]
        public IActionResult CreateHousekeeper(CreateHousekeeperViewModel createHousekeeper)
        {
            if (ModelState.IsValid)
            {
                _housekeeperService.Add(createHousekeeper);

                return RedirectToAction(nameof(HousekeeperIndex));
            }

            return View(createHousekeeper);
        }

        public IActionResult DetailsHousekeeper(int id)
        {
            Housekeeper housekeeper = _housekeeperService.FindById(id);

            if (housekeeper == null)
            {
                return RedirectToAction("HousekeeperIndex");
            }

            return View(housekeeper);
        }

        [HttpGet]
        public IActionResult EditHousekeeper(int id)
        {
            Housekeeper housekeeper = _housekeeperService.FindById(id);

            if (housekeeper == null)
            {
                return RedirectToAction("HousekeeperIndex");
            }

            EditHousekeeperViewModel editHousekeeper = new EditHousekeeperViewModel();
            editHousekeeper.Id = id;
            editHousekeeper.CreateHousekeeper = _housekeeperService.HousekeeperToCreateHousekeeper(housekeeper);

            return View(editHousekeeper);
        }

        [HttpPost]
        public IActionResult EditHousekeeper(int id, CreateHousekeeperViewModel createHousekeeper)
        {
            if (ModelState.IsValid)
            {
                Housekeeper housekeeper = _housekeeperService.Edit(id, createHousekeeper);

                return RedirectToAction(nameof(HousekeeperIndex));
            }

            EditHousekeeperViewModel editHousekeeper = new EditHousekeeperViewModel();
            editHousekeeper.Id = id;
            editHousekeeper.CreateHousekeeper = createHousekeeper;

            return View(editHousekeeper);
        }
    }
}
