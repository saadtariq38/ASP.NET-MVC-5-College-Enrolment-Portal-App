namespace mvcApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesToContactModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Query", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Query", c => c.String());
            AlterColumn("dbo.Contacts", "Phone", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "Name", c => c.String());
        }
    }
}
