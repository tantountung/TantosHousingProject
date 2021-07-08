using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Data
{
    public class Housekeeper
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string HousekeeperName { get; set; }

        [Required]
        [Phone]
        public string HousekeeperPhone { get; set; }

        [MaxLength(300)]
        public string HousekeeperAddress { get; set; }

        [MaxLength(100)]
        public string HousekeeperBankNumber { get; set; }

        [Required]
        public int HousekeeperLeave { get; set; }


        public DateTime LeaveDate { get; set; }

        //[Required]
        //public int HousekeeperRemainingLeave { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int HousekeeperSalary { get; set; }

        public DateTime SalaryPaidDate { get; set; }

        [Required]
        public DateTime HousekeeperStartDate { get; set; }

        public DateTime HousekeeperEndDate { get; set; }
    }
}