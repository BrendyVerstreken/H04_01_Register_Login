using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H04_01_Register_Login.Web.ViewModels
{
    public class InputVm
    {
        [Display (Name = "Naam")]
        public string Naam { get; set; }

        [Display(Name = "Voornaam")]
        public string Voornaam { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
