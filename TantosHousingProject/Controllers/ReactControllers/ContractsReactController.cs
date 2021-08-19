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
    public class ContractsReactController : ControllerBase
    {
        private readonly IContractService _contractService;
        private readonly ITenantService _tenantService;
        private readonly IRoomService _roomService;
        

        public ContractsReactController(IContractService contractService, IRoomService roomService, ITenantService tenantService)
        {
            _contractService = contractService;
            _roomService = roomService;
            _tenantService = tenantService;
        }

        [HttpGet]
        public List<Contract> Get()
        {
            return _contractService.JsonAll();
        }

        [HttpGet("{id}")]
        public Contract GetById(int id)
        {
            return _contractService.JsonFindBy(id);
        }

        //    Contract contract = _contractService.FindById(id);

        //    if (contract != null)
        //    {
        //        contract.RoomInQuestion.RoomHistory = null;
        //        contract.TenantInQuestion.TenantHistory = null;

        //        return contract;
        //    }

        //    throw new Exception("unable to find contract in the database");
        //}

        [HttpPost]
        public ActionResult<Contract> Create([FromBody] CreateContractViewModel contract)
        {
            //ModelState.isValid
            if (ModelState.IsValid)
            {
                return _contractService.Add(contract);
            }

            return BadRequest(contract);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_contractService.Remove(id))
            {
                Response.StatusCode = 200;
            }
            else
            {
                Response.StatusCode = 400;
            }
        }

        //----------------------- Room -----------------------

        [HttpGet("Rooms")]
        public List<Room> GetRooms()
        {
            return _roomService.JsonAll();
        }

        //----------------------- Tenant -----------------------

        [HttpGet("Tenants")]
        public List<Tenant> GetTenants()
        {
            return  _tenantService.JsonAll();
        }



    }
}
