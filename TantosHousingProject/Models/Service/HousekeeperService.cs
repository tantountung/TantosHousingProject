using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Repo;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public class HousekeeperService : IHousekeeperService
    {
        private readonly IGenericRepo<Housekeeper> _housekeeperRepo;

        public HousekeeperService(IGenericRepo<Housekeeper> housekeeperRepo)
        {
            _housekeeperRepo = housekeeperRepo;
        }

        public Housekeeper Add(CreateHousekeeperViewModel createHousekeeper)
        {
            Housekeeper Housekeeper = new Housekeeper();

            Housekeeper.HousekeeperName = createHousekeeper.HousekeeperName;
            Housekeeper.HousekeeperPhone = createHousekeeper.HousekeeperPhone;
            Housekeeper.HousekeeperAddress = createHousekeeper.HousekeeperAddress;
            Housekeeper.HousekeeperBankNumber = createHousekeeper.HousekeeperBankNumber;
            Housekeeper.HousekeeperLeave = createHousekeeper.HousekeeperLeave;
            Housekeeper.LeaveDate = createHousekeeper.LeaveDate;
            Housekeeper.HousekeeperSalary = createHousekeeper.HousekeeperSalary;
            Housekeeper.SalaryPaidDate = createHousekeeper.SalaryPaidDate;
            Housekeeper.HousekeeperStartDate = createHousekeeper.HousekeeperStartDate;
            Housekeeper.HousekeeperEndDate = createHousekeeper.HousekeeperEndDate;


            Housekeeper = _housekeeperRepo.Create(Housekeeper);

            return Housekeeper;
        }

        public HousekeeperIndexViewModel All()
        {
            HousekeeperIndexViewModel vm = new HousekeeperIndexViewModel();

            vm.HousekeeperList = _housekeeperRepo.Read();

            return vm;
        }


        public Housekeeper FindById(int id)
        {
            return _housekeeperRepo.Read(id);
        }

        public List<Housekeeper> FindByHousekeeperName(string housekeeperName)
        {
            List<Housekeeper> roomTypeList = new List<Housekeeper>();

            foreach (Housekeeper item in _housekeeperRepo.Read())
            {
                if (item.HousekeeperName.Equals(housekeeperName))
                {
                    roomTypeList.Add(item);
                }
            }

            return roomTypeList;
        }

        public Housekeeper Edit(int id, CreateHousekeeperViewModel createHousekeeper)
        {
            Housekeeper Housekeeper = FindById(id);

            if (createHousekeeper == null)
            {
                return null;
            }

            Housekeeper.HousekeeperName = createHousekeeper.HousekeeperName;
            Housekeeper.HousekeeperPhone = createHousekeeper.HousekeeperPhone;
            Housekeeper.HousekeeperAddress = createHousekeeper.HousekeeperAddress;
            Housekeeper.HousekeeperBankNumber = createHousekeeper.HousekeeperBankNumber;
            Housekeeper.HousekeeperLeave = createHousekeeper.HousekeeperLeave;
            Housekeeper.LeaveDate = createHousekeeper.LeaveDate;
            Housekeeper.HousekeeperSalary = createHousekeeper.HousekeeperSalary;
            Housekeeper.SalaryPaidDate = createHousekeeper.SalaryPaidDate;
            Housekeeper.HousekeeperStartDate = createHousekeeper.HousekeeperStartDate;
            Housekeeper.HousekeeperEndDate = createHousekeeper.HousekeeperEndDate;

            createHousekeeper = _housekeeperRepo.Update(createHousekeeper);

            return createHousekeeper;
        }
        public bool Remove(int id)
        {
            return _housekeeperRepo.Delete(id);
        }

        public CreateHousekeeperViewModel HousekeeperToCreateHousekeeper(Housekeeper createHousekeeper)
        {
            CreateHousekeeperViewModel Housekeeper = new CreateHousekeeperViewModel();

            Housekeeper.HousekeeperName = createHousekeeper.HousekeeperName;
            Housekeeper.HousekeeperPhone = createHousekeeper.HousekeeperPhone;
            Housekeeper.HousekeeperAddress = createHousekeeper.HousekeeperAddress;
            Housekeeper.HousekeeperBankNumber = createHousekeeper.HousekeeperBankNumber;
            Housekeeper.HousekeeperLeave = createHousekeeper.HousekeeperLeave;
            Housekeeper.LeaveDate = createHousekeeper.LeaveDate;
            Housekeeper.HousekeeperSalary = createHousekeeper.HousekeeperSalary;
            Housekeeper.SalaryPaidDate = createHousekeeper.SalaryPaidDate;
            Housekeeper.HousekeeperStartDate = createHousekeeper.HousekeeperStartDate;
            Housekeeper.HousekeeperEndDate = createHousekeeper.HousekeeperEndDate;

            return createHousekeeper;
        }
    }
}
