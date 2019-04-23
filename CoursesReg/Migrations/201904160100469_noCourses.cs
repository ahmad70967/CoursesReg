namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class noCourses : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Courses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Byte(nullable: false),
                        CourseName = c.String(),
                        Credits = c.Byte(nullable: false),
                        DepartmentId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
        }
    }
}
