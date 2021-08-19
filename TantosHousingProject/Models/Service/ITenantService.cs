using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public interface ITenantService
    {
        Tenant Add(CreateTenantViewModel createTenant);

        TenantIndexViewModel All();

        Tenant FindById(int id);

        public List<Tenant> JsonAll();
        List<Tenant> FindByTenantName(string tenantName);

        Tenant Edit(int id, CreateTenantViewModel tenant);

        CreateTenantViewModel TenantToCreateTenant(Tenant tenant);

        bool Remove(int id);
    }
}
