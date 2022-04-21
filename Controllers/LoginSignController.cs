using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeeklyFirstTask.DataAccess;
using WeeklyFirstTask.Models;
using Microsoft.Extensions.Hosting;
using AspNetCoreHero.ToastNotification.Abstractions;
//using NToastNotify;

namespace WeeklyFirstTask.Controllers
{
    public class LoginSignController : Controller
    {
        private readonly DataContext _context;
        //private readonly IToastNotification _toast;
        private readonly INotyfService _notyf;



        public LoginSignController(DataContext context,INotyfService notyf)
        {

            _context = context;
            //_toast = toast;
            _notyf = notyf;

        }
        public IActionResult Index()
        {
            var binddata = _context.GetUserDetails.ToList();
            return View(binddata);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationDetails r)
        {
            if (ModelState.IsValid)
            {
                //var getcount = _context.Countriess.SingleOrDefault(e => e.Cid == r.Cid);
                //var getst = _context.Statess.SingleOrDefault(e => e.Sid == r.Sid);
                UserDetails user = new UserDetails();
                {
                    user.UserName = r.UserName;
                    user.Email = r.Email;
                    user.Password = r.Password;
                    user.PhoneNo = r.PhoneNo;
                    user.Gender = r.Gender;
                    //user.C = getcount;
                    //user.S = getst;

                };
                _context.Add(user);
                _context.SaveChanges();
                
                _notyf.Custom("Registration successfull...", 5, "#0000FF", "fa fa-home");

            }
            else
            {
                return View("Registration");
            }
            return RedirectToAction("Login", "LoginSign");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginDetails obj1)
        {
            if (ModelState.IsValid)
            {
                var user = _context.GetUserDetails.FirstOrDefault(m => m.Email == obj1.Email && m.Password == obj1.Password);
                if (user == null)
                {
                    ModelState.AddModelError("Password", "Invalid login attempt.");
                    return View("Login");
                }
            }
            _notyf.Custom("Welcome",4, "#00FFFF", "fa fa-user fa-fw");
            _notyf.Custom("Get Appointment for Doctors", 8, "#808000", "fa fa-user fa-fw");
            return RedirectToAction("DoctorDetails", "Managements");

        }

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var data = _context.GetUserDetails.SingleOrDefault(x => x.Id == id);
            _context.GetUserDetails.Remove(data);
            _context.SaveChanges();
            _notyf.Custom("Record Succesfully Deleted...", 5, "#FF0000", "fa fa-trash-o");

            //_toast.AddSuccessToastMessage("Deleted sucessfully");
            //_toast.AddInfoToastMessage("Record Deleted Successfully,5");

            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {

            return RedirectToAction("Login");
        }

        //public JsonResult GetCountry()

        //{
        //    var cnt = _context.Countriess.ToList();
        //    return new JsonResult(cnt);
        //}

        //public JsonResult GetState(int id)

        //{
        //    var st = _context.Statess.Where(e => e.Country.Cid == id).ToList();

        //    return new JsonResult(st);
        //}

    

    }


}

