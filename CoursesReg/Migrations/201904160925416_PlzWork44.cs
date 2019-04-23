namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlzWork44 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Enrollments");
            AlterColumn("dbo.Enrollments", "TermCode", c => c.Int(nullable: false, identity: true));
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
