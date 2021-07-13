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
       public int Id { get; set; }
        
        [Required]
        public double RoomNumber { get; set; }

        
        [Required]
        [MaxLength(20)]
        public string RoomType { get; set; }

        //Many

        public List<Contract> RoomHistory { get; set; }

        public Room()
        {
            RoomHistory = new List<Contract>();
        }





    }
}
