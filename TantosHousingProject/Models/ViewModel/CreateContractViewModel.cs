using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.ViewModel
{
    public class CreateContractViewModel
    {
        [Required]
        public int RoomPrice { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }


        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Required]
        public Room RoomInQuestion { get; set; }


        [Required]
        public Tenant TenantInQuestion { get; set; }

        public List<Room> RoomList { get; set; }

        public List<Tenant> TenantList { get; set; }
    }
}

