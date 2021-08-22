using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Database;
using TantosHousingProject.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace TantosHousingProject.Models.Repo
{
    public class RoomRepo : IGenericRepo <Room>
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

            return tHPDbContext.Rooms.Include(room => room.RoomHistory )
                .ThenInclude(contract => contract.TenantInQuestion)
                .SingleOrDefault(row => row.RoomInQuestionId == id);

        }

        public List<Room> Read()
        {
            //return roomList;

            return tHPDbContext.Rooms.ToList();

        }

        public Room Update(Room modelName)
        {
            Room newContract = Read(modelName.RoomInQuestionId);

            if (newContract == null)
            {
                return null;
            }

            tHPDbContext.Update(modelName);

            int result = tHPDbContext.SaveChanges();

            if (result == 0)
            {
                return null;
            }

            return newContract;
        }
        
        
        public bool Delete(int id)
        {
            //    Room room = Read(id);

            //    if (room == null)
            //    {
            //        return false;
            //    }

            //return roomList.Remove(room);

            Room newContract = Read(id);

            if (newContract == null)
            {
                return false;
            }

            tHPDbContext.Rooms.Remove(newContract);

            int result = tHPDbContext.SaveChanges();

            if (result == 0)
            {
                return false;
            }

            return true;
        }
    }
}
