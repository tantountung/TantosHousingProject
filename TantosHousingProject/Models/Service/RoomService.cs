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
        private readonly IGenericRepo<Room> _roomRepo;

        public RoomService(IGenericRepo<Room> roomRepo)
        {
            _roomRepo = roomRepo;
        }


        public Room Add(CreateRoomViewModel createRoom)
        {
            Room room = new Room();

            room.RoomNumber = createRoom.RoomNumber;
            room.RoomType = createRoom.RoomType;
           
            room = _roomRepo.Create(room);

            return room;
        }

        public RoomIndexViewModel All()
        {
            RoomIndexViewModel vm = new RoomIndexViewModel();

            vm.RoomList = _roomRepo.Read();

            return vm;
        }
       

        public Room FindById(int id)
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
            Room oriRoom = FindById(id);

            if (oriRoom == null)
            {
                return null;
            }

            oriRoom.RoomNumber = room.RoomNumber;
            oriRoom.RoomType = room.RoomType;       

            oriRoom = _roomRepo.Update(oriRoom);

            return oriRoom;
        }
        public bool Remove(int id)
        {
            return _roomRepo.Delete(id);
        }

        public CreateRoomViewModel RoomToCreateRoom(Room room)
        {
            CreateRoomViewModel createRoom = new CreateRoomViewModel();

            createRoom.RoomNumber = room.RoomNumber;
            createRoom.RoomType = room.RoomType;

            return createRoom;
        }
    }
}
