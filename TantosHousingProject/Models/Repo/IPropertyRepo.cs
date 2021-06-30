using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Repo
{
    public interface IPropertyRepo 
    {
        Property Create(CreatePropertyViewModel createProperty);

        Property Read(int id);
        List<Property> Read();
        Property Update(Property model);

        bool Delete(int id);
    }
}
