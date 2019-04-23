namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentForekeyFinal2 : DbMigration
    {
        public override void Up()
        {

            CreateIndex("dbo.Courses", "DepartmentId");
           // AddForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropTable("dbo.Departments");

        }
    }
}
