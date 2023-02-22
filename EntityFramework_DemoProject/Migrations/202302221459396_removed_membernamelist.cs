namespace EntityFramework_DemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removed_membernamelist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventModels", "MemberName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EventModels", "MemberName");
        }
    }
}
