using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.Repo
{
    public class TenantsRepo : IGenericRepo<Tenants, CreateTenantsViewModel>
    {
        public Tenants Create(CreateTenantsViewModel create)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Tenants Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tenants> Read()
        {
            throw new NotImplementedException();
        }

        public Tenants Update(Tenants model)
        {
            throw new NotImplementedException();
        }
    }
}
