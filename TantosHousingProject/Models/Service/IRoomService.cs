﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public interface IRoomService
    {
        Room Add(CreateRoomViewModel createRoom);

        RoomIndexViewModel All();

        Room FindByRoomNumber(int id);


        List<Room> FindByType(string type);

        Room Edit(int id, CreateRoomViewModel room);

        bool Remove(int id);


    }
}
