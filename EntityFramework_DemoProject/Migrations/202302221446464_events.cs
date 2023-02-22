namespace EntityFramework_DemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class events : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EventModels", "MemberName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EventModels", "MemberName", c => c.String());
        }
    }
}
