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
            return View(_roomService.All());
        }

        [HttpPost]
        public IActionResult RoomIndex(RoomIndexViewModel vm)
        {
            vm.RoomList = _roomService.FindByType(vm.FilterText);

            return View(vm);
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
                _roomService.Add(createRoom);
            }

            return View(createRoom);
        }

        public IActionResult Details(int id)
        {
            Room room = _roomService.FindByRoomNumber(id);

            if (room == null)
            {
                return RedirectToAction("RoomIndex");
            }

            return View(room);
        }
    }
}
