using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public class TenantService : ITenantService
    {
        public Tenant Add(CreateTenantViewModel createTenant)
        {
            throw new NotImplementedException();
        }

        public List<Tenant> All()
        {
            throw new NotImplementedException();
        }

        public Tenant Edit(int id, CreateTenantViewModel tenant)
        {
            throw new NotImplementedException();
        }

        public Tenant FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tenant> FindByTenantId(int tenantId)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public CreateTenantViewModel TenantToCreateTenant(Tenant tenant)
        {
            throw new NotImplementedException();
        }
    }
}
