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
        [MaxLength(20)]
        public string RoomType { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int RoomPrice { get; set; }

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
