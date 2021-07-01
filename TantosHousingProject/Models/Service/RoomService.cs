using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public class RoomService
    {
        static int idCounter = 100;
        static List<Room> roomList = new List<Room>();

        public Room AddRoom(CreateRoomViewModel createRoom)
        {
            Room room = new Room();
            room.RoomNumber = ++idCounter;
            room.RoomType = createRoom.RoomType;
            room.RoomPrice = createRoom.RoomPrice;

            roomList.Add(room);

            return room;
        }

        public List<Room> GetAll()
        {
            return roomList;
        }
    }
}
