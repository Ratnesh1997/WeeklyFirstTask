using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeklyFirstTask.DataAccess;
using WeeklyFirstTask.Models;

namespace WeeklyFirstTask.Controllers
{
    public class ManagementsController : Controller
    {
        private readonly DataContext _conn;

        public ManagementsController(DataContext conn)
        {

            _conn = conn;


        }
        public IActionResult DoctorDetails()
        {
            var data =  _conn.GetDoctors.ToList();
            return View(data);

        }
        [HttpPost]
        public IActionResult DoctorDetails(Doctor doctors)
        {
           
            return View();

        }
        public IActionResult AppointDetails(int id)
        {
            //var getData = _conn.GetDoctors.SingleOrDefault(x => x.DId == id);
            var getData = (from D in _conn.GetDoctors where D.DId == id select new Doctor
            {
                DName = D.DName,
                Contact =D.Contact,
                Specialization = D.Specialization,
            }).SingleOrDefault();
            return View(getData);

        }
    }
}
