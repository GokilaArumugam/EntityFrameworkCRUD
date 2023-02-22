using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.WebPages.Html;

namespace EntityFramework_DemoProject.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string Venue { get; set; }
        public DateTime EventDate { get; set; }
        public string NSS { get; set; }
        public string YRC { get; set; }
        public string TTC { get; set; }
    }
}