using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.ViewModel
{
    public class EditTenantViewModel
    {
        public int Id { get; set; }

        public CreateTenantViewModel CreateTenant { get; set; }
    }
}
