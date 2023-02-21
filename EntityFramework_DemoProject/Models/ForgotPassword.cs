using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EntityFramework_DemoProject.Models
{
    public class ForgotPassword
    {
        [Required, DataType(DataType.EmailAddress), DisplayName("Email Id")]
        public string Email_ID { get; set; }
        [Required, DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required, DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}