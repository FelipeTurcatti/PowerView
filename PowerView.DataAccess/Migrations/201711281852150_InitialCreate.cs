namespace PowerView.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Controller",
                c => new
                    {
                        ControllerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Description = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ControllerId);
            
            CreateTable(
                "dbo.Metric",
                c => new
                    {
                        MetricId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Description = c.String(nullable: false, maxLength: 200),
                        UnitMeasurement_UnitMeasurementId = c.Int(nullable: false),
                        Controller_ControllerId = c.Int(),
                    })
                .PrimaryKey(t => t.MetricId)
                .ForeignKey("dbo.UnitMeasurement", t => t.UnitMeasurement_UnitMeasurementId, cascadeDelete: true)
                .ForeignKey("dbo.Controller", t => t.Controller_ControllerId)
                .Index(t => t.UnitMeasurement_UnitMeasurementId)
                .Index(t => t.Controller_ControllerId);
            
            CreateTable(
                "dbo.UnitMeasurement",
                c => new
                    {
                        UnitMeasurementId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Simbol = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.UnitMeasurementId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        TelephoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Metric", "Controller_ControllerId", "dbo.Controller");
            DropForeignKey("dbo.Metric", "UnitMeasurement_UnitMeasurementId", "dbo.UnitMeasurement");
            DropIndex("dbo.Metric", new[] { "Controller_ControllerId" });
            DropIndex("dbo.Metric", new[] { "UnitMeasurement_UnitMeasurementId" });
            DropTable("dbo.User");
            DropTable("dbo.UnitMeasurement");
            DropTable("dbo.Metric");
            DropTable("dbo.Controller");
        }
    }
}
