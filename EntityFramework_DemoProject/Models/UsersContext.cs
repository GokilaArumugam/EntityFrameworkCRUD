using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntityFramework_DemoProject.Models
{
    public class UsersContext:DbContext
    {
        public UsersContext() : base("connectionstring")
        {

        }
        public DbSet<UsersModelcs> User { get; set; }
        public DbSet<Register> registers { get; set; }
    }
}