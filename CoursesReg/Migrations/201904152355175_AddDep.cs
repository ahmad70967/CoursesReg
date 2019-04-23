namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDep : DbMigration
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

           
        }
        
        public override void Down()
        {
        }
    }
}
