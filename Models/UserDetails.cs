using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeeklyFirstTask.Models
{
    public class UserDetails
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }

        //public Country C { get; set; }

        //public State S { get; set; }
    }
}
