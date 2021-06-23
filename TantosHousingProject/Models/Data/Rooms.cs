﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.Data
{
    public class Rooms
    {
        [Key]
        public int RoomNumber { get; set; }

        [Required]
        public string RoomType { get; set; }

        [Required]
        public int RoomPrice { get; set; }

        [Required]
        public string RoomOccupancy { get; set; }

        public DateTime RoomCycle { get; set; }


        public string RoomPayment { get; set; }

        public DateTime PaymentDate { get; set; }

        public int PaymentAmount { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime ReminderSent { get; set; }


    }
}
