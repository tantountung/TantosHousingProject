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

       List<Tenant> All();

        Tenant FindById(int id);


        List<Tenant> FindByTenantId(int tenantId);

        Tenant Edit(int id, CreateTenantViewModel tenant);

        CreateTenantViewModel TenantToCreateTenant(Tenant tenant);

        bool Remove(int id);
    }
}
