using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFramework_DemoProject.Models
{
    public class ClubsModel
    {
        public int Id { get; set; }
        [Required, DataType(DataType.Text)]
        public string  MemberName { get; set; }
        [Required, DataType(DataType.Text)]
        public string Venue { get; set; }
        public DateTime Event_Date { get; set; }
        public string NSS { get; set;}
        public string YRC { get; set; }
        public string TTC { get; set; }


    }
}