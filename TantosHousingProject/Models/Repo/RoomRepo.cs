using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Database;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.Repo
{
    public class RoomRepo : IRoomRepo
    {
        private readonly THPDbContext tHPDbContext;

        public RoomRepo(THPDbContext tHPDbContext)
        {
            this.tHPDbContext = tHPDbContext;
        }

        //List<Room> roomList = new List<Room>();
        //int idCounter = 0;

        public Room Create(Room room)
        {
            //room.Id = ++idCounter;
            //roomList.Add(room);

            //return room;

            tHPDbContext.Rooms.Add(room);

            int result = tHPDbContext.SaveChanges();

            if (result == 0)
            {
                throw new Exception("unable to create room in the database");
            }

            return room;
        }
               

        public Room Read(int id)
        {
            //foreach (Room item in roomList)
            //{
            //    if (item.Id == id)
            //    {
            //        return item;
            //    }
            //}

            //return null;

            return tHPDbContext.Rooms.SingleOrDefault(row => row.Id == id);

        }

        public List<Room> Read()
        {
            //return roomList;

            return tHPDbContext.Rooms.ToList();

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
            //    Room room = Read(id);

            //    if (room == null)
            //    {
            //        return false;
            //    }

            //return roomList.Remove(room);

            throw new NotImplementedException();
        }
    }
}
