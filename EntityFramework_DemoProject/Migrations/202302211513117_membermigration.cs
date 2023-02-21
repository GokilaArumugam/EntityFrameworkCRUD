namespace EntityFramework_DemoProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class membermigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UsersModelcs", newName: "Members");
            AlterColumn("dbo.Members", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "Address", c => c.String(nullable: false));
            RenameTable(name: "dbo.Members", newName: "UsersModelcs");
        }
    }
}
