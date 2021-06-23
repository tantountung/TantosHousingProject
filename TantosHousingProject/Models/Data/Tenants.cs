using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Data
{
    public class Tenants
    {
        [Key]
        public int TenantId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenantName { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenantPhone { get; set; }

        [Required]
        public string TenantDocument { get; set; }
    }
}
