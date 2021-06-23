using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Data
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }

        [Required]
        [MaxLength(100)]
        public string PropertyName { get; set; }

        [MaxLength(300)]
        public string PropertyAddress { get; set; }


        public int YearBuilt { get; set; }


        public string PropertyTaxNumber { get; set; }


    }
}
