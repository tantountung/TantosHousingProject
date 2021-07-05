using System;
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

        Room FindById(int id);


        List<Room> FindByType(string type);

        Room Edit(int id, CreateRoomViewModel room);

        CreateRoomViewModel RoomToCreateRoom(Room room);

        bool Remove(int id);


    }
}
