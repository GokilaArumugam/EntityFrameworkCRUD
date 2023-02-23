using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EntityFramework_DemoProject.Models;
using System.Data.Entity.Migrations;
using Microsoft.Win32;

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
        public ActionResult SignUp(Register register)
        {
            UsersContext db = new UsersContext();
            var user = db.User.Where(m => m.Email_ID == register.Email_ID).FirstOrDefault();
            if (user == null)
            {
                db.registers.Add(register);
                db.SaveChanges();
                return RedirectToAction("SignIn");
            }
            else
            {
                TempData["Error"] = "Provided Email_ID is already Registered!";
            }
            return View("SignUp", new Members());
        }
        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(Register login)
        {
            using (var db = new UsersContext())
            {
                var userlogin = db.registers.Where(m => m.Email_ID == login.Email_ID && m.Password == login.Password).FirstOrDefault();
                if (userlogin != null)
                {
                    TempData["Success"] = "Login Successfully!";
                    TempData["Welcome"] = userlogin.Name;
                    return RedirectToAction("Members", "Member");
                }
                else
                {
                    TempData["Error"] = "Wrong Email_Id or Password!";
                }
            }
            return View(login);
        }
        [HttpGet]
        public ActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ResetPassword(Register forgotpassword)
        {
            using (var db = new UsersContext())
            {
                var user = db.registers.Where(m=>m.Email_ID==forgotpassword.Email_ID).FirstOrDefault();
                if (user != null)
                {
                    user.Password= forgotpassword.Password;
                    user.ConfirmPassword = forgotpassword.ConfirmPassword;
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Success"] = "Reset Password Successfully!";
                    return RedirectToAction("SignIn", "Users");
                }
                else 
                {
                    TempData["Error"] = "Wrong Email_Id!";
                }
            }
            return View();
        }
    }
}