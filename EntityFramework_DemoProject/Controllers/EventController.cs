using EntityFramework_DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EntityFramework_DemoProject.Controllers
{
    public class EventController : Controller
    {
        public List<ClubsModel>GetEventList()
        {
            using (var db = new UsersContext())
            {
                return db.Event.ToList();
            }
        }
        public ActionResult EventTable()
        {
            List<ClubsModel> list = GetEventList();
            return View(list);
        }
        public ActionResult SearchBy(string search) 
        {
            UsersContext context = new UsersContext();
            var searchevent = context.Event.Where(m => m.MemberName.Contains(search.ToString()) ||
            m.Venue.Contains(search.ToString()));
            return View("EventTable",searchevent.ToList());
        }
        [HttpGet]
        public ActionResult EventDetails(int id=0)
        {
            ClubsModel userTb = new ClubsModel();
            if (id != 0)
            {
                using (var db = new UsersContext())
                {
                    userTb = db.Event.Where(m => m.Id == id).FirstOrDefault();
                }
            }
            return View(userTb);  
        }
        [HttpPost]
        public ActionResult EventDetails(ClubsModel entity)
        {
            using (var context = new UsersContext())
            {
                context.Entry(entity).State = entity.Id == 0 ?
                                           EntityState.Added :
                                           EntityState.Modified;
                entity.Id = entity.Id == 0 ? 0 : entity.Id;

                context.SaveChanges();
            }
            return View("EventTable",GetEventList());
        }
        [HttpGet]
        public ActionResult DeleteEvent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteEvent(int id)
        {
            using (var db = new UsersContext())
            {
                var userTb = db.Event.Where(m => m.Id == id).FirstOrDefault();
                db.Event.Remove(userTb);
                db.SaveChanges();
            }
            return View("Event",GetEventList());
        }

    }
}