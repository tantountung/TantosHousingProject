using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Database;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.Repo
{
    public class ContractRepo : IGenericRepo <Contract>
    {
        private readonly THPDbContext tHPDbContext;

        public ContractRepo(THPDbContext tHPDbContext)
        {
            this.tHPDbContext = tHPDbContext;
        }

        public Contract Create(Contract contract)
        {           
            tHPDbContext.Contracts.Add(contract);

            int result = tHPDbContext.SaveChanges();

            if (result == 0)
            {
                throw new Exception("unable to create contract in the database");
            }

            return contract;
        }
               

        public Contract Read(int id)
        {         
            return tHPDbContext.Contracts.SingleOrDefault(row => row.Id == id);
        }

        public List<Contract> Read()
        {

            return tHPDbContext.Contracts.ToList();

        }

        public Contract Update(Contract contract)
        {
            Contract newContract = Read(contract.Id);

            if (newContract == null)
            {
                return null;
            }

            //newContract.ContractNumber = contract.ContractNumber;
            //newContract.ContractType = contract.ContractType;
           
            return newContract;
        }
        
        
        public bool Delete(int id)
        {
         
            throw new NotImplementedException();
        }
    }
}
