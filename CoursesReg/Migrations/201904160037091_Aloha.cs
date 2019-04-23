namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aloha : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "DepartmentId", c => c.Byte(nullable: false));
            
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Courses", "DepartmentId");
        }
    }
}
