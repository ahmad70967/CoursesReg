namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoursesPhase1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            //CreateIndex("dbo.Courses", "DepartmentId");
           // AddForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
           // DropIndex("dbo.Courses", new[] { "DepartmentId" });
            //DropTable("dbo.Departments");
        }
    }
}
