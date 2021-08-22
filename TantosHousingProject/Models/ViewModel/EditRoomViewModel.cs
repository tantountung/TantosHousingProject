using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.ViewModel
{
    public class EditRoomViewModel
    {
        public int RoomInQuestionId { get; set; }

        public CreateRoomViewModel CreateRoom { get; set; }

        public EditRoomViewModel()
        {
            CreateRoom = new CreateRoomViewModel();
        }
    }
}
