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

        public ContractService(IGenericRepo<Contract> contractRepo)
        {
            _contractRepo = contractRepo;
        }


        public Contract Add(CreateContractViewModel createContract)
        {
            Contract contract = new Contract();

            contract.RoomInQuestion = createContract.RoomInQuestion;
            contract.TenantInQuestion = createContract.TenantInQuestion;
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
