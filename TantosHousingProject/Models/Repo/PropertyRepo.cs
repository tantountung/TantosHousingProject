using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Repo
{
    public class PropertyRepo : IPropertyRepo
    {
        int idCounter = 0;
        List<Property> propertyList = new List<Property>();

        public Property Create(CreatePropertyViewModel createProperty)
        {
            Property property = new Property();

            property.PropertyId = ++idCounter;
            property.PropertyName = createProperty.PropertyName;
            property.PropertyAddress = createProperty.PropertyAddress;
            property.YearBuilt = createProperty.YearBuilt;
            property.PropertyTaxNumber = createProperty.PropertyTaxNumber;

            propertyList.Add(property);

            return property;

        }

        public Property Read(int id)
        {
            foreach (Property item in propertyList)
            { 
                if (item.PropertyId == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Property> Read()
        {
            return propertyList;
        }

        public Property Update(Property model)
        {
            Property originalProperty = Read(model.PropertyId);

            if (originalProperty == null)
            {
                return null;
            }

            originalProperty.PropertyName = model.PropertyName;
            originalProperty.PropertyAddress = model.PropertyAddress;
            originalProperty.YearBuilt = model.YearBuilt;
            originalProperty.PropertyTaxNumber = model.PropertyTaxNumber;

            return originalProperty;

        }

        public bool Delete(int id)
        {
            Property originalProperty = Read(id);

            if (originalProperty == null)
            {
                return false;
            }

            return propertyList.Remove(originalProperty);
        }

    }
}
