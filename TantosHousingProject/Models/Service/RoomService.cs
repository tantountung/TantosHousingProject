using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Repo;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public class RoomService : IRoomService
    {
        IRoomRepo _roomRepo;

        public RoomService()
        {
            _roomRepo = new RoomRepo();
        }


        public Room Add(CreateRoomViewModel createRoom)
        {
            Room room = new Room();

            room.RoomType = createRoom.RoomType;
            room.RoomPrice = createRoom.RoomPrice;

            room = _roomRepo.Create(room);

            return room;
        }

        public RoomIndexViewModel All()
        {
            RoomIndexViewModel vm = new RoomIndexViewModel();

            vm.RoomList = _roomRepo.Read();

            return vm;
        }
       

        public Room FindByRoomNumber(int id)
        {
            return _roomRepo.Read(id);
        }

        public List<Room> FindByType(string type)
        {
            List<Room> roomTypeList = new List<Room>();

            foreach (Room item in _roomRepo.Read())
            {
                if (item.RoomType.Equals(type))
                {
                    roomTypeList.Add(item);
                }
            }

            return roomTypeList;
        }

 public Room Edit(int id, CreateRoomViewModel room)
        {
            Room oriRoom = FindByRoomNumber(id);

            if (oriRoom == null)
            {
                return null;
            }

            oriRoom.RoomType = room.RoomType;
            oriRoom.RoomPrice = room.RoomPrice;

            oriRoom = _roomRepo.Update(oriRoom);

            return oriRoom;
        }
        public bool Remove(int id)
        {
            return _roomRepo.Delete(id);
        }
    }
}
