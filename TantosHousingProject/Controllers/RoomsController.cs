using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Service;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Controllers
{
    public class RoomsController : Controller
    {
        RoomService _roomService = new RoomService();
        public IActionResult RoomIndex()
        {
            return View(_roomService.GetAll());
        }

        [HttpGet]
        public IActionResult CreateRoom()
        {
            return View(new CreateRoomViewModel());
        }
       
        [HttpPost]
        public IActionResult CreateRoom(CreateRoomViewModel createRoom)
        {
            if (ModelState.IsValid)
            {
                _roomService.AddRoom(createRoom);
            }

            return View(createRoom);
        }
    }
}
