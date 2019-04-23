namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlzWork4244 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Courses", "Id");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Courses", "Id");
            AddForeignKey("dbo.Enrollments", "CoursesId", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}
