using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.ViewModel
{
    public class EditContractViewModel
    {
        public int Id { get; set; }

        public CreateContractViewModel CreateContract { get; set; }

        //public EditContractViewModel()
        //{
        //    CreateContract = new CreateContractViewModel();
        //}
    }
}
