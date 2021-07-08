using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.ViewModel
{
    public class HousekeeperIndexViewModel
    {
        public string FilterText { get; set; }

        public List<Housekeeper> HousekeeperList { get; set; }
    }
}