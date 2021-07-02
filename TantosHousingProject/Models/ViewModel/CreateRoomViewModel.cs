﻿using Magnum.Binding.TypeBinders;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.ViewModel
{
    public class CreateRoomViewModel
    {     
        [Required]
        public double RoomNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string RoomType { get; set; }

        public List<String> TypeList { get; set; }

        public CreateRoomViewModel()
        {
            TypeList = new List<String>()
            {
                "Suite",
                "Deluxe",
                "Standard"
            };
        }
    }
}
