namespace mvcApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedForeignKeyAndTeacherToCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "TeacherId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "TeacherId");
            AddForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers", "TeacherId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropColumn("dbo.Courses", "TeacherId");
        }
    }
}
