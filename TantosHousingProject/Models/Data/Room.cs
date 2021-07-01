using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Data
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string RoomType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int RoomPrice { get; set; }

        //[Required]
        //public string RoomOccupancy { get; set; }

        //public DateTime RoomCycle { get; set; }


        //public string RoomPayment { get; set; }

        //public DateTime PaymentDate { get; set; }

        //[DataType(DataType.Currency)]
        //public int PaymentAmount { get; set; }

        //[Required]
        //public DateTime StartDate { get; set; }

        //public DateTime EndDate { get; set; }

        //public DateTime ReminderSent { get; set; }


    }
}
