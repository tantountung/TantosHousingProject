using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Repo;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public class ContractService : IContractService
    {
        private readonly IGenericRepo<Contract> _contractRepo;
        private readonly IGenericRepo<Tenant> _tenantRepo;
        private readonly IGenericRepo<Room> _roomRepo;

        public ContractService(IGenericRepo<Contract> contractRepo, IGenericRepo<Tenant> tenantRepo, IGenericRepo<Room> roomRepo)
        {
            _contractRepo = contractRepo;
          _tenantRepo = tenantRepo;
           _roomRepo = roomRepo;
        }


        public Contract Add(CreateContractViewModel createContract)
        {
            Contract contract = new Contract();

            contract.RoomInQuestion = _roomRepo.Read(createContract.RoomInQuestionId);
            contract.TenantInQuestion = _tenantRepo.Read(createContract.TenantInQuestionId);
            contract.RoomPrice = createContract.RoomPrice;
            contract.PaymentDate = createContract.PaymentDate;
            contract.StartDate = createContract.StartDate;
            contract.EndDate = createContract.EndDate;

            return _contractRepo.Create(contract);
        }

        public List<Contract> All()
        {
            return _contractRepo.Read();
        }

        public CreateContractViewModel ContractToCreateContract(Contract contract)
        {
            throw new NotImplementedException();
        }

        public Contract Edit(int id, CreateContractViewModel contract)
        {
            throw new NotImplementedException();
        }

        public Contract FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contract> FindByRoomId(int RoomId)
        {
            throw new NotImplementedException();
        }

        public List<Contract> FindByTenantId(int TenantId)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
