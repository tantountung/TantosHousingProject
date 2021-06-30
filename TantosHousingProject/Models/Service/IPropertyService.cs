using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public interface IPropertyService
    {
        Property Add(CreatePropertyViewModel createProperty);

        PropertyIndexViewModel All();

        Property FindById(int id);

        List<Property> FindByName(string propertyName);

        Property Edit(int id, CreatePropertyViewModel createProperty);

        bool Remove(int id);

    }
}
