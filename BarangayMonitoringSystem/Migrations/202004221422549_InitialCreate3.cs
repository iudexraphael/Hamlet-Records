namespace BarangayMonitoringSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clearances",
                c => new
                    {
                        ClearanceId = c.Int(nullable: false, identity: true),
                        ResidentId = c.Int(nullable: false),
                        Residentname = c.String(),
                        Cedula = c.String(),
                        BarangayId = c.String(),
                        RegisteredVoter = c.String(),
                        BGClearance = c.String(),
                    })
                .PrimaryKey(t => t.ClearanceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clearances");
        }
    }
}
