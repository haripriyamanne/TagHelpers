using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpers.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "FirstName is mandatory")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "LastName is mandatory")]
        public string LastName { get; set; }
        //[RegularExpression("^[a-z0-9][@][g][m][a][i][l][.][c][o][m]$")]
        [Required(ErrorMessage = "Email is mandatory")]
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        [RegularExpression("^[6-9]{1}[0-9]{9}$")]
        [Required(ErrorMessage = "Phone Number is mandatory")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Enter Password")]
        public string Password { get; set; }
        public string Description { get; set; }
    }
}
