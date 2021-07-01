using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.ViewModel
{
    public class RoomIndexViewModel
    {
        public string FilterText { get; set; }

        public List<Room> RoomList { get; set; }
    }
}
