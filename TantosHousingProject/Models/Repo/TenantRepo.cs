using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Database;
using TantosHousingProject.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace TantosHousingProject.Models.Repo
{
    public class TenantRepo : IGenericRepo<Tenant>
    {
        private readonly THPDbContext _tHPDbContext;

        public TenantRepo(THPDbContext tHPDbContext)
        {
            _tHPDbContext = tHPDbContext;
        }
        public Tenant Create(Tenant tenant)
        {
            _tHPDbContext.Tenants.Add(tenant);

            int result = _tHPDbContext.SaveChanges();

            if (result == 0)
            {
                throw new Exception("unable to create tenant in the database");
            }

            return tenant;
        }

        
        public Tenant Read(int id)
        {
            return _tHPDbContext.Tenants.Include(tenant => tenant.TenantHistory)
                .ThenInclude(contract => contract.RoomInQuestion)
                .SingleOrDefault(row => row.Id == id);
        }

        public List<Tenant> Read()
        {
            return _tHPDbContext.Tenants.ToList();
        }

        public Tenant Update(Tenant modelName)
        {
            Tenant newContract = Read(modelName.Id);

            if (newContract == null)
            {
                return null;
            }

            _tHPDbContext.Update(modelName);           

            int result = _tHPDbContext.SaveChanges();

            if (result == 0)
            {
                return null;
            }

            return newContract;
        }

        public bool Delete(int id)
        {
            Tenant newContract = Read(id);

            if (newContract == null)
            {
                return false;
            }

            _tHPDbContext.Tenants.Remove(newContract);

            int result = _tHPDbContext.SaveChanges();

            if (result == 0)
            {
                return false;
            }

            return true;
        }
    }
}
