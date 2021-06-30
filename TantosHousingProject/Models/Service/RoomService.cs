using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Repo;

namespace TantosHousingProject.Models.Service
{

    public class RoomService : IRoomService
    {
        IRoomRepo _roomRepo;

        public RoomService(IRoomRepo roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public CarIndexViewModel All()
        {
            CarIndexViewModel indexViewModel = new CarIndexViewModel();

            indexViewModel.CarList = _carRepo.Read();

            return indexViewModel;
        }

        public Room FindById(int id)
        {
            return _carRepo.Read(id);
        }

        public List<Room> FindByBrand(string brand)
        {
            List<Room> carBrandList = new List<Room>();

            foreach (Room item in _carRepo.Read())
            {
                if (item.Brand.Equals(brand))
                {
                    carBrandList.Add(item);
                }
            }

            return carBrandList;
        }

        public Room Edit(int id, CreateCar Room)
        {
            Room originalCar = FindById(id);

            if (originalCar == null)
            {
                return null;
            }

            originalCar.Brand = Room.Brand;
            originalCar.ModelName = Room.ModelName;
            originalCar.Price = Room.Price;

            originalCar = _carRepo.Update(originalCar);

            return originalCar;
        }

        public bool Remove(int id)
        {
            return _carRepo.Delete(id);
        }

        public CreateCar CarToCreateCar(Room Room)
        {
            CreateCar createCar = new CreateCar(_carBrandRepo);

            createCar.Brand = Room.Brand;
            createCar.ModelName = Room.ModelName;
            createCar.Price = Room.Price;

            return createCar;
        }
    }
}
