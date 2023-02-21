namespace EntityFramework_DemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changepassword : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ForgotModels",
                c => new
                    {
                        Email_ID = c.String(nullable: false, maxLength: 128),
                        NewPassword = c.String(nullable: false),
                        ConfirmPassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Email_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ForgotModels");
        }
    }
}
