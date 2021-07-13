using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Data
{
    public class Tenant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenantName { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenantPhone { get; set; }

        [Required]
        public string TenantDocument { get; set; }

        public List<Contract> TenantHistory { get; set; }

        public Tenant()
        {
            TenantHistory = new List<Contract>();
        }
    }
}
