namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlzWork3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Enrollments");
            AlterColumn("dbo.Enrollments", "TermCode", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Enrollments", "TermCode");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Enrollments");
            AlterColumn("dbo.Enrollments", "TermCode", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Enrollments", "TermCode");
        }
    }
}
