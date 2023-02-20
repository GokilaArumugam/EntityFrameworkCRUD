using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EntityFramework_DemoProject.Models;
using System.Data.Entity.Migrations;

namespace EntityFramework_DemoProject.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UsersModelcs usermodel)
        {
            UsersContext db = new UsersContext();
            usermodel.SelectType = "Staff";
            usermodel.University = "AnnaUniversity";
            usermodel.Department = "CivilEngineering";
            usermodel.City = "Chennai";
            var user = db.User.Where(m => m.Email_ID == usermodel.Email_ID).FirstOrDefault();
            if (user == null)
            {
                db.User.Add(usermodel);
                db.SaveChanges();
               return RedirectToAction("SignIn");
            }
            else
            {
                TempData["Error"] = "Provided Email_ID is already Registered!";
            }
            return View("SignUp", new UsersModelcs());
        }
        [HttpGet]
        public ActionResult SignIn()
        {

            return View();
        }
        [HttpPost]
        public ActionResult SignIn(UsersModelcs usermodel)
        {
            using (var db = new UsersContext())
            {
                var userlogin = db.User.Where(m => m.Email_ID == usermodel.Email_ID && m.Password == usermodel.Password).FirstOrDefault();
               if(userlogin == null) 
               {
                    TempData["Error"] = "Wrong Email_Id or Password!";
               }
                else
                {
                    TempData["Success"] = "Login Successfully!";
                    return RedirectToAction("Members","Member");
                }
            }
            return View(usermodel);
        }
    }
}