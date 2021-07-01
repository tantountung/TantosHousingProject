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
        //IRoomService _roomService;

        //public RoomsController(IRoomService roomService)
        //{
        //   _roomService = roomService;
        //}

        [HttpGet]
        public IActionResult RoomIndex()
        {
            return View(_roomService.All());
        }

        //public IActionResult RoomIndex(RoomIndexViewModel vm)
        //{
        //    vm.RoomList = _roomService.FindByType(vm.FilterText);

        //    return View(vm);
        //}

        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateRoomViewModel(_roomTypeRepo));
        }

        [HttpPost]
        public IActionResult Create(CreateRoomViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _roomService.Add(vm);

                return RedirectToAction(nameof(RoomIndex));
            }

            return View(vm);
        }

        //    public IActionResult Details(int id)
        //    {
        //        Room room = _roomService.FindByRoomNumber(id);

        //        if (room == null)
        //        {
        //            return RedirectToAction("RoomIndex");
        //        }

        //        return View(room);
        //    }

        //    [HttpGet]
        //    public IActionResult Edit(int id)
        //    {
        //        Room room = _roomService.FindByRoomNumber(id);

        //        if (room == null)
        //        {
        //            return RedirectToAction("RoomIndex");
        //        }

        //        EditRoom editRoom = new EditRoom();
        //        editRoom.RoomNumber = id;
        //        editRoom.CreateRoomViewModel = _roomService.RoomToCreateRoom(room);

        //        return View(editRoom);
        //    }

        //    [HttpPost]
        //    public IActionResult Edit(int id, CreateRoomViewModel vm)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            Room room = _roomService.Edit(id, vm);

        //            return RedirectToAction(nameof(RoomIndex));
        //        }

        //        EditRoom editRoom = new EditRoom();
        //        editRoom.RoomNumber = id;
        //        editRoom.CreateRoomViewModel = _roomService.RoomToCreateRoom(room);

        //        return View(editRoom);
        //    }
    }
}
