using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace EntityFramework_DemoProject.Models
{
    public class EventsModel
    {
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, DataType(DataType.Text)]
        public string MemberName { get; set; }
        [Required, DataType(DataType.Text)]
        public string Venue { get; set; }
        public DateTime EventDate { get; set; }
        public string NSS { get; set; }
        public string YRC { get; set; }
        public string TTC { get; set; }
    }
}