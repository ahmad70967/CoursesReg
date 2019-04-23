namespace CoursesReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmissionFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "AdmissionTermCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "AdmissionTermCode", c => c.String());
        }
    }
}
