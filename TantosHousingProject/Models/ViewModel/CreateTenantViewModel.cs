using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.ViewModel
{
    public class CreateTenantViewModel
    {
        [Required]
        [StringLength(100)]
        public string TenantName { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenantPhone { get; set; }

        [Required]
        public string TenantDocument { get; set; }

        public List<String> DocumentList { get; set; }

        public CreateTenantViewModel()
        {
            DocumentList = new List<String>()
            {
                "Received",
                "Requested",
                "Not Requested"
            };
        }
    }
}
