﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.Repo
{
    public class InMemoryRoomRepo : IRoomRepo<Room>
    {
        List<Room> roomList = new List<Room>();

        public Room Create(Room model)
        {
            roomList.Add(model);

            return model;
        }


        public Room Read(int id)
        {
            foreach (Room item in roomList)
            {
                if (item.RoomNumber == id)
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

        public Room Update(Room model)
        {
            Room originalRoom = Read(model.RoomNumber);

            if (originalRoom == null)
            {
                return null;
            }

            originalRoom.RoomType = model.RoomType;
            originalRoom.RoomPrice = model.RoomPrice;

            return originalRoom;
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
