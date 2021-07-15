using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TantosHousingProject.Models.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        
        [Required]
        [DataType(DataType.Password)]
        [StringLength(60, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
