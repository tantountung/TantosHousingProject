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
    
    public class TenantsController : Controller
    {
        private readonly ITenantService _tenantService;

        public TenantsController(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }


       public IActionResult TenantIndex()
        {
            return View(_tenantService.All());
        }

        [HttpPost]
        public IActionResult TenantIndex(TenantIndexViewModel vm)
        {
            vm.TenantList = _tenantService.FindByTenantName(vm.FilterText);

            return View(vm);
        }

        [HttpGet]
        public IActionResult CreateTenant()
        {
            return View(new CreateTenantViewModel());
        }
       
        [HttpPost]
        public IActionResult CreateTenant(CreateTenantViewModel createTenant)
        {
            if (ModelState.IsValid)
            {
                _tenantService.Add(createTenant);

                return RedirectToAction(nameof(TenantIndex));
            }

            return View(createTenant);
        }

        public IActionResult DetailsTenant(int id)
        {
            Tenant tenant = _tenantService.FindById(id);

            if (tenant == null)
            {
                return RedirectToAction("TenantIndex");
            }

            return View(tenant);
        }

        [HttpGet]
        public IActionResult EditTenant(int id)
        {
            Tenant tenant = _tenantService.FindById(id);

            if (tenant == null)
            {
                return RedirectToAction("TenantIndex");
            }

            EditTenantViewModel editTenant = new EditTenantViewModel();
            editTenant.Id = id;
            editTenant.CreateTenant = _tenantService.TenantToCreateTenant(tenant);

            return View(editTenant);
        }

        [HttpPost]
        public IActionResult EditTenant(int id, CreateTenantViewModel createTenant)
        {
            if (ModelState.IsValid)
            {
                Tenant tenant = _tenantService.Edit(id, createTenant);

                return RedirectToAction(nameof(TenantIndex));
            }

            EditTenantViewModel editTenant = new EditTenantViewModel();
            editTenant.Id = id;
            editTenant.CreateTenant = createTenant;

            return View(editTenant);
        }
    }
}
