namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlzWork : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropPrimaryKey("dbo.Courses");
            DropPrimaryKey("dbo.Enrollments");
            AlterColumn("dbo.Courses", "Id", c => c.Byte(nullable: false, identity: true));
            AlterColumn("dbo.Enrollments", "TermCode", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Courses", "Id");
            AddPrimaryKey("dbo.Enrollments", "TermCode");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropPrimaryKey("dbo.Enrollments");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Enrollments", "TermCode", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Courses", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Enrollments", "TermCode");
            AddPrimaryKey("dbo.Courses", "Id");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}
