﻿using System;
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
        public DbSet<Members> User { get; set; }
        public DbSet<Register> registers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<UsersContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
   
}