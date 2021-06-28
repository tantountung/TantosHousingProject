using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Controllers
{
    public class PropertiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreatePropertyViewModel());
        }

        [HttpPost]
        public IActionResult Create(CreatePropertyViewModel createProperty)
        {
            if (ModelState.IsValid)
            {

            }

            return View(createProperty);
        }
    }
}
