using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeeklyFirstTask.Models
{
    public class LoginDetails
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter email address")]
        public string Email { get; set;}


        [Required(ErrorMessage = " please enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        internal void addmodelerror(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
