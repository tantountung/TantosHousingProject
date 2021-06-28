using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.Repo
{
    public class PropertyRepo : IGenericRepo<Property, CreatePropertyViewModel>
    {
        public Property Create(CreatePropertyViewModel create)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Property Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Property> Read()
        {
            throw new NotImplementedException();
        }

        public Property Update(Property model)
        {
            throw new NotImplementedException();
        }
    }
}
