using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TantosHousingProject.Models.Data;

namespace TantosHousingProject.Models.ViewModel
{
    public class ContractIndexViewModel
    {
        public string FilterText { get; set; }

        public List<Contract> ContractList { get; set; }

        public ContractIndexViewModel()
        {
            ContractList = new List<Contract>();
        }
    }
}