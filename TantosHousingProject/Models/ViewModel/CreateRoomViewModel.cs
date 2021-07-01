using Magnum.Binding.TypeBinders;
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
        public string RoomType { get; set; }

        [Required]
        [ModelBinder(BinderType = typeof(DoubleBinder))]
        [DataType(DataType.Currency)]
        public int RoomPrice { get; set; }

        //public List<String> TypeList { get; set; }

        public CreateRoomViewModel()
        {
            //zero constructor
        }

        //public CreateRoomViewModel(IRoomTypeRepo roomTypeRepo)
        //{
        //    TypeList = new List<String>();

        //    foreach (var item in roomTypeRepo.Read())
        //    {
        //        TypeList.Add(item.Name);
        //    }

        //}
    }
}
