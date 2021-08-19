using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;
using Contract = TantosHousingProject.Models.Data.Contract;

namespace TantosHousingProject.Models.Service
{
    public interface IContractService
    {
        Contract Add(CreateContractViewModel createContract);

        List<Contract> All();

        List<Contract> JsonAll();

        Contract JsonFindBy(int id);

        Contract FindById(int id);

        List<Contract> FindByRoomId(int RoomId);

        List<Contract> FindByTenantId(int TenantId);

        Contract Edit(int id, CreateContractViewModel contract);

        CreateContractViewModel ContractToCreateContract(Contract contract);

        bool Remove(int id);
    }
}
