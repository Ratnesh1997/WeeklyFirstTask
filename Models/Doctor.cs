using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeeklyFirstTask.Models
{
    public class Doctor: Appointment
    {
        [Key]
        public int DId { get; set; }
        public string DName { get; set; }
        public string Contact { get; set; }

        public string Specialization { get; set; }
    }
}
