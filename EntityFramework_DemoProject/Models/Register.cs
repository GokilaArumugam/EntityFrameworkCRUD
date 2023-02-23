using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_DemoProject.Models
{
    public class Register
    {
        public int Id { get; set; }
        [Required, DataType(DataType.Text)]
        public string Name { get; set; }
        public string Gender { get; set; }
        [Required, Range(18, 50)]
        public int Age { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Address { get; set; }
        public long MobileNo { get; set; }
        [Required, DataType(DataType.EmailAddress), DisplayName("Email Id")]
        public string Email_ID { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string Country { get; set; }
    }
}
