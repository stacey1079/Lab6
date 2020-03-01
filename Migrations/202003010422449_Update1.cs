namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "Notes", c => c.String());
            CreateIndex("dbo.Enrollments", "StudentId");
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Students", "StudentId", cascadeDelete: true);
            DropColumn("dbo.Enrollments", "Student");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Enrollments", "Student", c => c.String());
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Students");
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropColumn("dbo.Enrollments", "Notes");
        }
    }
}
