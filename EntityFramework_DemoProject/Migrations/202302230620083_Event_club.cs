namespace EntityFramework_DemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Event_club : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClubsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MemberName = c.String(nullable: false),
                        Venue = c.String(nullable: false),
                        Event_Date = c.DateTime(nullable: false),
                        NSS = c.String(),
                        YRC = c.String(),
                        TTC = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClubsModels");
        }
    }
}
