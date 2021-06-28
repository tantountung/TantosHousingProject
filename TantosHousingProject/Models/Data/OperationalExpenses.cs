using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Data
{
    public class OperationalExpenses
    {
        [Key]
        public int OpExpenseId { get; set; }

        [Required]
        public DateTime OpExpenseDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string OpExpenseItem { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int OpExpenseAmount { get; set; }


        [MaxLength(999)]
        public string OpExpenseDetails { get; set; }

        [MaxLength(30)]
        public string OpExpenseInvoiceCode { get; set; }
    }
}
