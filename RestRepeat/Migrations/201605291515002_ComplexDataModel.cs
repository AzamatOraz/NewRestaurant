namespace RestRepeat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComplexDataModel : DbMigration
    {
        public override void Up()
        {
            // Create  a department for course to point to.
            Sql("INSERT INTO dbo.Department (Name, Budget, StartDate) VALUES ('Temp', 0.00, GETDATE())");
            //  default value for FK points to department created above.
            AddColumn("dbo.Course", "DepartmentID", c => c.Int(nullable: false, defaultValue: 1));
            //AddColumn("dbo.Course", "DepartmentID", c => c.Int(nullable: false));

            AlterColumn("dbo.Client", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Client", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Staff", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Staff", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Department", "DepartmentName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Menu", "FoodType", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menu", "FoodType", c => c.String());
            AlterColumn("dbo.Department", "DepartmentName", c => c.String());
            AlterColumn("dbo.Staff", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Staff", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Client", "FirstName", c => c.String());
            AlterColumn("dbo.Client", "LastName", c => c.String());
        }
    }
}
