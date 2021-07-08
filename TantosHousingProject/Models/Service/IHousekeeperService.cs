using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public interface IHousekeeperService
    {
        Housekeeper Add(CreateHousekeeperViewModel createHousekeeper);

        HousekeeperIndexViewModel All();

        Housekeeper FindById(int id);


        List<Housekeeper> FindByHousekeeperName(string housekeeperName);

        Housekeeper Edit(int id, CreateHousekeeperViewModel housekeeper);

        CreateHousekeeperViewModel HousekeeperToCreateHousekeeper(Housekeeper housekeeper);

        bool Remove(int id);
    }
}
