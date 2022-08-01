namespace mvcApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherAndCourseTablesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        CourseTaught = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
            DropColumn("dbo.Courses", "InstructorName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "InstructorName", c => c.String());
            DropTable("dbo.Teachers");
        }
    }
}
