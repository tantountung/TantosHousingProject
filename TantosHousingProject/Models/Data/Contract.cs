using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Data
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RoomPrice { get; set; }

        //[Required]
        //public string RoomOccupancy { get; set; }

        //public DateTime RoomCycle { get; set; }


        //public string RoomPayment { get; set; } //checkbox if fully paid
        [Required]
        public DateTime PaymentDate { get; set; }

        //[DataType(DataType.Currency)]
        //public int PaymentAmount { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        //public DateTime ReminderSent { get; set; }

        [ForeignKey("RoomInQuestion")]
        public int RoomInQuestionId { get; set; }

        //One
        [Required]
        public Room RoomInQuestion { get; set; }

        [ForeignKey("TenantInQuestion")]
        public int TenantInQuestionId { get; set; }

        //One
        [Required]
        public Tenant TenantInQuestion { get; set; }

        public Contract()
        {

        }


    }
}
