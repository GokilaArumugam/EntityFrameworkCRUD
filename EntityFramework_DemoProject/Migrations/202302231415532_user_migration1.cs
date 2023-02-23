namespace EntityFramework_DemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_migration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registers", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registers", "Country");
        }
    }
}
