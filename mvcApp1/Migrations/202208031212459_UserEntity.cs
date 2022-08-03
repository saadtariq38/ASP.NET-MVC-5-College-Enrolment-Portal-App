namespace mvcApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserEntity : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "IsActive", c => c.Int(nullable: false));
        }
    }
}
