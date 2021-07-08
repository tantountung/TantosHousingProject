using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Repo;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public class TenantService : ITenantService
    {
        private readonly IGenericRepo<Tenant> _tenantRepo;

        public TenantService(IGenericRepo<Tenant> tenantRepo)
        {
            _tenantRepo = tenantRepo;
        }

        public Tenant Add(CreateTenantViewModel createTenant)
        {
            Tenant Tenant = new Tenant();

            Tenant.TenantName = createTenant.TenantName;
            Tenant.TenantPhone = createTenant.TenantPhone;
            Tenant.TenantDocument = createTenant.TenantDocument;

            Tenant = _tenantRepo.Create(Tenant);

            return Tenant;
        }

        public TenantIndexViewModel All()
        {
            TenantIndexViewModel vm = new TenantIndexViewModel();

            vm.TenantList = _tenantRepo.Read();

            return vm;
        }


        public Tenant FindById(int id)
        {
            return _tenantRepo.Read(id);
        }

        public List<Tenant> FindByTenantName(string tenantName)
        {
            List<Tenant> roomTypeList = new List<Tenant>();

            foreach (Tenant item in _tenantRepo.Read())
            {
                if (item.TenantName.Equals(tenantName))
                {
                    roomTypeList.Add(item);
                }
            }

            return roomTypeList;
        }

        public Tenant Edit(int id, CreateTenantViewModel tenant)
        {
            Tenant oriRoom = FindById(id);

            if (oriRoom == null)
            {
                return null;
            }

            oriRoom.TenantName = tenant.TenantName;
            oriRoom.TenantPhone = tenant.TenantPhone;
            oriRoom.TenantDocument = tenant.TenantDocument;

            oriRoom = _tenantRepo.Update(oriRoom);

            return oriRoom;
        }
        public bool Remove(int id)
        {
            return _tenantRepo.Delete(id);
        }

        public CreateTenantViewModel TenantToCreateTenant(Tenant tenant)
        {
            CreateTenantViewModel createRoom = new CreateTenantViewModel();

            createRoom.TenantName = tenant.TenantName;
            createRoom.TenantPhone = tenant.TenantPhone;
            createRoom.TenantDocument = tenant.TenantDocument;

            return createRoom;
        }
    }
}
