using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Database;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.Repo
{
    public class HousekeeperRepo : IGenericRepo<Housekeeper>
    {
        private readonly THPDbContext _tHPDbContext;

        public HousekeeperRepo(THPDbContext tHPDbContext)
        {
            _tHPDbContext = tHPDbContext;
        }
        public Housekeeper Create(Housekeeper housekeeper)
        {
            _tHPDbContext.Housekeepers.Add(housekeeper);

            int result = _tHPDbContext.SaveChanges();

            if (result == 0)
            {
                throw new Exception("unable to create housekeeper in the database");
            }

            return housekeeper;
        }

        
        public Housekeeper Read(int id)
        {
            return _tHPDbContext.Housekeepers.SingleOrDefault(row => row.Id == id);
        }

        public List<Housekeeper> Read()
        {
            return _tHPDbContext.Housekeepers.ToList();
        }

        public Housekeeper Update(Housekeeper modelName)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
