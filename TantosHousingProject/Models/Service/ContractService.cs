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

        public List<Contract> JsonAll()//created to avoid infinite loop,

        {
            List<Contract> newList = _contractRepo.Read();

            foreach (var person in newList)
            {
                person.RoomInQuestion.RoomHistory = null;
                person.TenantInQuestion.TenantHistory = null;
            }

            return newList;
        }

        public Contract JsonFindBy(int id)
        {
            Contract newPerson = _contractRepo.Read(id);

            //if (newPerson.RoomInQuestionId != null)

            //{
            //    newPerson.RoomInQuestion.RoomHistory = null;
            //    newPerson.TenantInQuestion.TenantHistory = null;
            //}

            return newPerson;
        }

        public Contract Edit(int id, CreateContractViewModel contract)
        {
            Contract contractToUpdate = FindById(id);

            if (contractToUpdate == null)
            {
                return null;
            }
            contractToUpdate.RoomInQuestionId = contract.RoomInQuestionId;
            contractToUpdate.TenantInQuestionId = contract.TenantInQuestionId;
            contractToUpdate.RoomPrice = contract.RoomPrice;
            contractToUpdate.PaymentDate = contract.PaymentDate;
            contractToUpdate.StartDate = contract.StartDate;
            contractToUpdate.EndDate = contract.EndDate;

            return _contractRepo.Update(contractToUpdate);
        }

        public Contract FindById(int id)
        {
            return _contractRepo.Read(id);
        }

        public List<Contract> FindByRoomId(int RoomId)
        {
            List<Contract> roomTypeList = new List<Contract>();

            foreach (Contract item in _contractRepo.Read())
            {
                if (item.RoomInQuestionId.Equals(RoomId))
                {
                    roomTypeList.Add(item);
                }
            }

            return roomTypeList;
        }

        public List<Contract> FindByTenantId(int TenantId)
        {
            List<Contract> roomTypeList = new List<Contract>();

            foreach (Contract item in _contractRepo.Read())
            {
                if (item.TenantInQuestionId.Equals(TenantId))
                {
                    roomTypeList.Add(item);
                }
            }

            return roomTypeList;
        }

        public bool Remove(int id)
        {
            return _contractRepo.Delete(id);
        }

        public CreateContractViewModel ContractToCreateContract(Contract contract)
        {
            CreateContractViewModel contractToUpdate = new CreateContractViewModel();

            contractToUpdate.RoomInQuestionId = contract.RoomInQuestionId;
            contractToUpdate.TenantInQuestionId = contract.TenantInQuestionId;
            contractToUpdate.RoomPrice = contract.RoomPrice;
            contractToUpdate.PaymentDate = contract.PaymentDate;
            contractToUpdate.StartDate = contract.StartDate;
            contractToUpdate.EndDate = contract.EndDate;

            return contractToUpdate;
        }
    }
}
