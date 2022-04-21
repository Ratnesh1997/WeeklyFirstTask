using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeeklyFirstTask.Models
{
    public class State
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public Country Country { get; set; }
    }
}
