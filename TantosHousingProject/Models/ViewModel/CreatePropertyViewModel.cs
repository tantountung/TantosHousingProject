using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.ViewModel
{
    public class CreatePropertyViewModel
    {
        [Key]
        [Required]
        public int PropertyId { get; set; }


        [Required]
        [MaxLength(100)]
        public string PropertyName { get; set; }

        [MaxLength(300)]
        public string PropertyAddress { get; set; }

        public int YearBuilt { get; set; }

        public string PropertyTaxNumber { get; set; }

        public List<Property> PropertyList { get; set; }

        public CreatePropertyViewModel()
        {
            PropertyList = new List<Property>();
        }
    }
}
