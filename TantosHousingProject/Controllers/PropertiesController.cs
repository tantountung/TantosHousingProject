using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Service;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Controllers
{
    public class PropertiesController : Controller
    {
        PropertyService _propertyService = new PropertyService();

        public IActionResult PropertyIndex()
        {
            return View(_propertyService.GetAll());
        }

        [HttpGet]
        public IActionResult CreatePropertyView()
        {
            return View(new CreatePropertyViewModel());
        }

        [HttpPost]
        public IActionResult CreatePropertyView(CreatePropertyViewModel createProperty)
        {
            if (ModelState.IsValid)
            {
                _propertyService.AddProperty(createProperty);

                return RedirectToAction(nameof(PropertyIndex));
            }

            return View(createProperty);
        }
    }
}
