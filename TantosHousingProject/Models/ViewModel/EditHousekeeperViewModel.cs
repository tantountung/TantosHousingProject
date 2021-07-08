using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.ViewModel
{
    public class EditHousekeeperViewModel
    {
        public int Id { get; set; }

        public CreateHousekeeperViewModel CreateHousekeeper { get; set; }
    }
}
