﻿using EntityFramework_DemoProject.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework_DemoProject.Controllers
{
    public class MemberController : Controller
    {
        private List<Members> GetList()
        {
            using (var db = new UsersContext())
            {
                return db.User.ToList();
            }
        }
        public ActionResult Members()
        {
            List<Members> listUser = GetList();
            return View(listUser);
        }
        [HttpGet]
        public ActionResult UserDetails(int id = 0)
        {
            Members userTb = new Members();
            if (id != 0)
            {
                using (var db = new UsersContext())
                {
                    userTb = db.User.Where(m => m.Id == id).FirstOrDefault();
                }
            }
            return View(userTb);
        }
        public ActionResult DeleteUser(int id)
        {
            using (var db = new UsersContext())
            {
                var userTb = db.User.Where(m => m.Id == id).FirstOrDefault();
                db.User.Remove(userTb);
                db.SaveChanges();
            }
            return View("Members", GetList());
        }
        [HttpPost]
        public ActionResult UserDetails(Members User)
        {
            UsersContext db = new UsersContext();
            var user = db.User.Where(m => m.Email_ID == User.Email_ID).FirstOrDefault();
            if (User.Id==0)
            {
                db.User.Add(User);
                db.SaveChanges();
                return RedirectToAction("Members");
            }
            else
            {
                db.Entry(User).State = EntityState.Modified;
            }
            db.SaveChanges();
            return View("Members", GetList());
        }
        //public ActionResult Update(Members User)
        //{
        //    using (var db = new UsersContext())
        //    {
        //        db.Entry(User).State = EntityState.Modified;
        //        db.SaveChanges();
        //    }
        //    return View(User);
        //}

    }

}
