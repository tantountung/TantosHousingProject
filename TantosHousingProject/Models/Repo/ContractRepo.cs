using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Database;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.Repo
{
    public class ContractRepo : IGenericRepo<Contract>
    {
        private readonly THPDbContext tHPDbContext;

        public ContractRepo(THPDbContext tHPDbContext)
        {
            this.tHPDbContext = tHPDbContext;
        }

        public Contract Create(Contract contract)
        {

            tHPDbContext.Contracts.Add(contract);

            int result = -1;

            try
            {
                result = tHPDbContext.SaveChanges();
            }
            catch (Exception after)
            {

                throw;
            }

            if (result == 0)
            {
                throw new Exception("unable to create contract in the database");
            }

            return contract;
        }


        public Contract Read(int id)
        {
            return tHPDbContext.Contracts
                    .Include(row => row.RoomInQuestion)
                .Include(row => row.TenantInQuestion)
                .SingleOrDefault(row => row.Id == id);
        }

        public List<Contract> Read()
        {

            return tHPDbContext.Contracts
                .Include(row => row.RoomInQuestion)
                .Include(row => row.TenantInQuestion)
                .ToList();

        }

        public List<Contract> JsonRead()
        {
            List<Contract> newList = tHPDbContext.Contracts
                .Include("Room")
                .Include("Tenant")
                .ToList();

            foreach (var person in newList)
            {
                person.RoomInQuestion.RoomHistory = null;
                person.TenantInQuestion.TenantHistory = null;
            }

            return newList;
        }

        public Contract Update(Contract contract)
        {
            Contract newContract = Read(contract.Id);

            if (newContract == null)
            {
                return null;
            }

            tHPDbContext.Update(contract);

            //newContract.RoomInQuestion = contract.RoomInQuestion;
            //newContract.TenantInQuestion = contract.TenantInQuestion;
            //newContract.RoomPrice = contract.RoomPrice;
            //newContract.PaymentDate = contract.PaymentDate;
            //newContract.StartDate = contract.StartDate;
            //newContract.EndDate = contract.EndDate;

            int result = tHPDbContext.SaveChanges();

            if (result == 0)
            {
                return null;
            }

            return newContract;
        }


        public bool Delete(int id)
        {
            Contract newContract = Read(id);

            if (newContract == null)
            {
                return false;
            }

            tHPDbContext.Contracts.Remove(newContract);

            int result = tHPDbContext.SaveChanges();

            if (result == 0)
            {
                return false;
            }

            return true;
        }
    }
}
