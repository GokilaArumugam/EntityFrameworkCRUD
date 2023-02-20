using EntityFramework_DemoProject.Models;
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
        private List<UsersModelcs> GetList()
        {
            using (var db = new UsersContext())
            {
                return db.User.ToList();
            }
        }
        public ActionResult Members()
        {
            List<UsersModelcs> listUser = GetList();
            return View(listUser);
        }
        public ActionResult UserDetails(int id=0 ) 
        {
            UsersModelcs userTb = new UsersModelcs();
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
            return View("MembersTB", GetList());
        }
        public ActionResult AddUpdate(UsersModelcs User)
        {
            using (var db = new UsersContext())
            {
                if (User.Id == 0)
                {
                    db.User.Add(User);
                }
                else
                {
                    db.Entry(User).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            return View("MembersTB", GetList());
        }
     

    }
}