using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public class ContractService : IContractService
    {
        public ContractService(THPDBContext)
        {

        }


        public Contract Add(CreateContractViewModel createContract)
        {
            throw new NotImplementedException();
        }

        public List<Contract> All()
        {
            throw new NotImplementedException();
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
