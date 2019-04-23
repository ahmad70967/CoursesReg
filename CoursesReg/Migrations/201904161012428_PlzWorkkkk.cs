namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlzWorkkkk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Id", c => c.Byte(nullable: false, identity: true));
        }
        
        public override void Down()
        {
        }
    }
}
