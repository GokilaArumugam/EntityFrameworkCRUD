namespace EntityFramework_DemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigrates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsersModelcs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        MobileNo = c.Long(nullable: false),
                        Email_ID = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(nullable: false),
                        SelectType = c.String(),
                        University = c.String(nullable: false),
                        Department = c.String(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UsersModelcs");
        }
    }
}
