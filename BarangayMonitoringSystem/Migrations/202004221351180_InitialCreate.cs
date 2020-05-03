namespace BarangayMonitoringSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Barangayclearances");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Barangayclearances",
                c => new
                    {
                        ClearanceId = c.Int(nullable: false, identity: true),
                        Residentname = c.String(nullable: false),
                        ResidentId = c.Int(nullable: false),
                        Cedula = c.String(),
                        BarangayId = c.String(),
                        RegisteredVoter = c.String(),
                        BGClearance = c.String(),
                    })
                .PrimaryKey(t => t.ClearanceId);
            
        }
    }
}
