using EntityFramework_DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFramework_DemoProject.Controllers
{
    public class MemberTableController : Controller
    {
        private List<Members> GetList()
        {
            using (var db = new UsersContext())
            {
                return db.User.ToList();
            }
        }
        public ActionResult MemberTb()
        {
            List<Members> list = GetList();
            return View(list);
        }

    }
}