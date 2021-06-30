using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.Repo;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public class PropertyService : IPropertyService
    {
        IPropertyRepo _propertyRepo;

        public PropertyService(IPropertyRepo propertyRepo)
        {
            _propertyRepo = new PropertyRepo();
        }

        public Property Add(CreatePropertyViewModel createProperty)
        {
            Property person1 = _propertyRepo.Create(createProperty);

            return person1;            
        }

        public PropertyIndexViewModel All()
        {
            throw new NotImplementedException();
        }

        public Property Edit(int id, CreatePropertyViewModel createProperty)
        {
            throw new NotImplementedException();
        }

        public Property FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Property> FindByName(string propertyName)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
       