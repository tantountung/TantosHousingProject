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

        public RoomService(IRoomRepo roomRepo)
        {
            _roomRepo = roomRepo;
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
            Room editRoom = FindByRoomNumber(id);

            if (editRoom == null)
            {
                return null;
            }

            editRoom.RoomType = room.RoomType;
            editRoom.RoomPrice = room.RoomPrice;

            editRoom = _roomRepo.Update(editRoom);

            return editRoom;
        }

        public bool Remove(int id)
        {
            return _roomRepo.Delete(id);
        }

        //public CreateRoomViewModel RoomToCreateRoom(Room room)
        //{
        //    CreateRoomViewModel vm = new CreateRoomViewModel(_roomTypeRepo);

        //    vm.RoomType = room.RoomType;
        //    vm.RoomPrice = room.RoomPrice;

        //    return vm;
        //}
    }
}
