using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.Repo
{
    public interface IRoomRepo
    {
        Room Create(Room room);

        Room Read(int id);
        List<Room> Read();
        Room Update(Room room);

        bool Delete(int id);
    }
}
