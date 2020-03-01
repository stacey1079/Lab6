namespace EnrollmentApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Enrollments", "Address1", c => c.String());
            AddColumn("dbo.Enrollments", "Address2", c => c.String());
            AddColumn("dbo.Enrollments", "City", c => c.String());
            AddColumn("dbo.Enrollments", "Zipcode", c => c.String());
            AddColumn("dbo.Enrollments", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Enrollments", "State");
            DropColumn("dbo.Enrollments", "Zipcode");
            DropColumn("dbo.Enrollments", "City");
            DropColumn("dbo.Enrollments", "Address2");
            DropColumn("dbo.Enrollments", "Address1");
        }
    }
}
