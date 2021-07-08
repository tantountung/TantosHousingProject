using Microsoft.AspNetCore.Components.Forms;
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
        IRoomService _roomService;
        

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

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

                return RedirectToAction(nameof(RoomIndex));
            }

            return View(createRoom);
        }

        public IActionResult DetailsRoom(int id)
        {
            Room room = _roomService.FindById(id);

            if (room == null)
            {
                return RedirectToAction("RoomIndex");
            }

            return View(room);
        }

        [HttpGet]
        public IActionResult EditRoom(int id)
        {
            Room room = _roomService.FindById(id);

            if (room == null)
            {
                return RedirectToAction("RoomIndex");
            }

            EditRoomViewModel editRoom = new EditRoomViewModel();
            editRoom.Id = id;
            editRoom.CreateRoom = _roomService.RoomToCreateRoom(room);

            return View(editRoom);
        }

        [HttpPost]
        public IActionResult EditRoom(int id, CreateRoomViewModel createRoom)
        {
            if (ModelState.IsValid)
            {
                Room room = _roomService.Edit(id, createRoom);

                return RedirectToAction(nameof(RoomIndex));
            }

            EditRoomViewModel editRoom = new EditRoomViewModel();
            editRoom.Id = id;
            editRoom.CreateRoom = createRoom;

            return View(editRoom);
        }

    }
}
