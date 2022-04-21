using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeeklyFirstTask.Models
{
    public class RegistrationDetails
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter user name")]
       
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
         public string Email { get; set; }


        [Required(ErrorMessage = " please enter Password")]
        [StringLength(30, MinimumLength = 4,
                  ErrorMessage = "Password length should be min 4 character")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = " please enter confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter Mobile No")]
        [Display(Name = "enter Mobile No")]
        public string PhoneNo { get; set; }


        [Required(ErrorMessage = "Please Choose Gender")]
        [Display(Name = "Choose Gender")]
        public string Gender { get; set; }

        //public int Sid { get; set; }
        //public string Sname { get; set; }

        //public int Cid { get; set; }
        //public string Cname { get; set; }
    }
}
