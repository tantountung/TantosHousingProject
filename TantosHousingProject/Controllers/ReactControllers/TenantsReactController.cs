using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Service;
using TantosHousingProject.Models.Repo;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Controllers
{
    [EnableCors("ReactPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class TenantsReactController : ControllerBase
    {
        private readonly ITenantService _tenantService;
        //private readonly IContractService _contractService;

        public TenantsReactController(ITenantService tenantService)
        {
            _tenantService = tenantService;
            //_contractService = contractService;
        }

        [HttpGet]
        public List<Tenant> Get()
        {
            return _tenantService.All().TenantList;
        }

        [HttpGet("{id}")]
        public Tenant GetById(int id)
        {
            Tenant tenant = _tenantService.FindById(id);

            foreach (Contract contract in tenant.TenantHistory)
            {
                contract.TenantInQuestion = null;

                if (contract.RoomInQuestion != null)
                {
                    contract.RoomInQuestion.RoomHistory = null;
                }
            }

            return tenant;
        }

        [HttpPost]
        public ActionResult<Tenant> Create([FromBody] CreateTenantViewModel tenant)
        {
            //ModelState.isValid
            if (ModelState.IsValid)
            {
                return _tenantService.Add(tenant);
            }

            return BadRequest(tenant);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_tenantService.Remove(id))
            {
                Response.StatusCode = 200;
            }
            else
            {
                Response.StatusCode = 400;
            }
        }


    }
}
