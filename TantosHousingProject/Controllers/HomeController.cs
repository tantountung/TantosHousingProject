using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Service;

namespace TantosHousingProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContractService _contractService;

        public HomeController(ILogger<HomeController> logger, IContractService contractService)
        {
            _logger = logger;
            _contractService = contractService;
        }

        //[Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
 //           if (User.Identity.IsAuthenticated)

 //           {
 //List<Contract> contractList = _contractService.All();
 //           Contract lastContract = null;

 //           if (contractList.Count > 0)
 //           {
 //               lastContract = contractList[contractList.Count - 1];
 //           }

 //           return View(lastContract);
 //           }

 //           else
 //           {
                return View("PropertyInfo");
            //}
        }

        public IActionResult PropertyInfo()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
