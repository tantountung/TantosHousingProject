using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Data
{
    public class PettyCash
    {
        [Key]
        public int PettyCashId { get; set; }

        [Required]
        public DateTime PettyCashDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string PettyCashItem { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int PettyCashAmount { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public int PettyCashBalance { get; set; }


        [MaxLength(999)]
        public string PettyCashDetails { get; set; }

        [MaxLength(30)]
        public string PettyCashInvoiceCode { get; set; }
    }
}
