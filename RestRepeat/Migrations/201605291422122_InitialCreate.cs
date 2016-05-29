namespace RestRepeat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Accumulation = c.Int(nullable: false),
                        Manager_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Staff", t => t.Manager_ID)
                .Index(t => t.Manager_ID);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Mail = c.String(),
                        Password = c.String(),
                        HireDate = c.DateTime(nullable: false),
                        Department_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Department", t => t.Department_ID)
                .Index(t => t.Department_ID);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FoodType = c.String(),
                        Manager_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Staff", t => t.Manager_ID)
                .Index(t => t.Manager_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menu", "Manager_ID", "dbo.Staff");
            DropForeignKey("dbo.Client", "Manager_ID", "dbo.Staff");
            DropForeignKey("dbo.Staff", "Department_ID", "dbo.Department");
            DropIndex("dbo.Menu", new[] { "Manager_ID" });
            DropIndex("dbo.Staff", new[] { "Department_ID" });
            DropIndex("dbo.Client", new[] { "Manager_ID" });
            DropTable("dbo.Menu");
            DropTable("dbo.Department");
            DropTable("dbo.Staff");
            DropTable("dbo.Client");
        }
    }
}
