using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.Repo
{
    public class RoomRepo : IRoomRepo
    {
        static List<Room> roomList = new List<Room>();
        static int idCounter = 0;

        public Room Create(Room room)
        {
            room.Id = ++idCounter;
            roomList.Add(room);

            return room;
        }
               

        public Room Read(int id)
        {
            foreach (Room item in roomList)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }

        public List<Room> Read()
        {
            return roomList;
        }

        public Room Update(Room room)
        {
            Room newRoom = Read(room.Id);

            if (newRoom == null)
            {
                return null;
            }

            newRoom.RoomNumber = room.RoomNumber;
            newRoom.RoomType = room.RoomType;
           
            return newRoom;
        }
        
        
        public bool Delete(int id)
        {
            Room room = Read(id);

            if (room == null)
            {
                return false;
            }

            return roomList.Remove(room);
        }
    }
}
