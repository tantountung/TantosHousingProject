using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;
using TantosHousingProject.Models.ViewModel;

namespace TantosHousingProject.Models.Service
{
    public class PropertyService
    {
        static List<Property> propertyList = new List<Property>();

        public Property AddProperty (CreatePropertyViewModel createProperty)
        {

            Property property = new Property();

            property.PropertyId = createProperty.PropertyId;
            property.PropertyName = createProperty.PropertyName;
            property.PropertyAddress = createProperty.PropertyAddress;
            property.YearBuilt = createProperty.YearBuilt;
            property.PropertyTaxNumber = createProperty.PropertyTaxNumber;

            propertyList.Add(property);

            return property;
        }

        public List<Property> GetAll()
        {
            return propertyList;
        }

    }
}
