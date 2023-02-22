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
        public List<EventModel>GetEventList()
        {
            using (var db = new UsersContext())
            {
                return db.Events.ToList();
            }
        }
        public ActionResult EventTable()
        {
            List<EventModel> list = GetEventList();
            return View(list);
        }
        public ActionResult SearchBy(string search) 
        {
            UsersContext context = new UsersContext();
            var searchevent = context.Events.Where(m => m.MemberName.Contains(search.ToString()) ||
            m.Venue.Contains(search.ToString()));
            return View("EventTable",searchevent.ToList());
        }
        public ActionResult EventDetails(int id=0)
        {
            EventModel userTb = new EventModel();
            if (id != 0)
            {
                using (var db = new UsersContext())
                {
                    userTb = db.Events.Where(m => m.Id == id).FirstOrDefault();
                }
            }
            return View(userTb);  
        }
        public ActionResult EventDetails(EventModel entity)
        {
            using (var context = new UsersContext())
            {
                context.Entry(entity).State = entity.Id == 0 ?
                                           EntityState.Added :
                                           EntityState.Modified;

                context.SaveChanges();
            }
            return View("EventTable",GetEventList());
        }
        public ActionResult DeleteEvent(int id)
        {
            using (var db = new UsersContext())
            {
                var userTb = db.Events.Where(m => m.Id == id).FirstOrDefault();
                db.Events.Remove(userTb);
                db.SaveChanges();
            }
            return View("Members",GetEventList());
        }

    }
}