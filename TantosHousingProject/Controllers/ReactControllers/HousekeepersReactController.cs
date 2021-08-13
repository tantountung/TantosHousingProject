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
    public class HousekeepersReactController : ControllerBase
    {
        private readonly IHousekeeperService _housekeeperService;
        //private readonly IContractService _contractService;

        public HousekeepersReactController(IHousekeeperService housekeeperService)
        {
            _housekeeperService = housekeeperService;
            //_contractService = contractService;
        }

        [HttpGet]
        public List<Housekeeper> Get()
        {
            return _housekeeperService.All().HousekeeperList;
        }

        [HttpGet("{id}")]
        public Housekeeper GetById(int id)
        {
            Housekeeper housekeeper = _housekeeperService.FindById(id);
                       
            return housekeeper;
        }

        [HttpPost]
        public ActionResult<Housekeeper> Create([FromBody] CreateHousekeeperViewModel housekeeper)
        {
            //ModelState.isValid
            if (ModelState.IsValid)
            {
                return _housekeeperService.Add(housekeeper);
            }

            return BadRequest(housekeeper);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_housekeeperService.Remove(id))
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
