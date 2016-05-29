namespace RestRepeat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthOnNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Staff", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Staff", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Staff", "Password", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Staff", "Password", c => c.String());
            AlterColumn("dbo.Staff", "FirstName", c => c.String());
            AlterColumn("dbo.Staff", "LastName", c => c.String());
        }
    }
}
