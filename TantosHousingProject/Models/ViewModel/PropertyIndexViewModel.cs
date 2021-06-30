using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.ViewModel
{
    public class PropertyIndexViewModel
    {
        public string FilterText { get; set; }

        public List<Property> PropertyList { get; set; }
    }
}
