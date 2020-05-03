namespace BarangayMonitoringSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blotterreports", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.Blotterreports", "DateIncident", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blotterreports", "DateIncident", c => c.String());
            AlterColumn("dbo.Blotterreports", "Status", c => c.String());
        }
    }
}
