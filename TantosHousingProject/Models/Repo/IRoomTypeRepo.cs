using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Repo
{
    public interface IRoomTypeRepo
    {
        RoomType Create(RoomType roomType);

        RoomType Read(int id);

        List<RoomType> Read();

        RoomType Update(RoomType roomType);

        bool Delete(int id);
    }
}
