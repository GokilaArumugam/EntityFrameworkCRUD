namespace EntityFramework_DemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _event : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.EventModels");
            AlterColumn("dbo.EventModels", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.EventModels", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.EventModels");
            AlterColumn("dbo.EventModels", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.EventModels", "Id");
        }
    }
}
