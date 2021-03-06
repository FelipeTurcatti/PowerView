namespace PowerView.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PowerView.DataAccess.PowerViewDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;        
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "PowerView.DataAccess.PowerViewDbContext";            
        }
        
        protected override void Seed(PowerView.DataAccess.PowerViewDbContext context)
        {
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            /*
            context.UnitMeasurements.AddOrUpdate(new Domain.UnitMeasurement() {UnitMeasurementId = 1, Name = "Volt", Simbol = "V" });

            context.UnitMeasurements.AddOrUpdate(new Domain.UnitMeasurement() { UnitMeasurementId = 2, Name = "Watts", Simbol = "W" });

            context.UnitMeasurements.AddOrUpdate(new Domain.UnitMeasurement() { UnitMeasurementId = 3, Name = "Ampere", Simbol = "I" });

            context.UnitMeasurements.AddOrUpdate(new Domain.UnitMeasurement() { UnitMeasurementId = 4, Name = "Hertz", Simbol = "Hz" });

            context.UnitMeasurements.AddOrUpdate(new Domain.UnitMeasurement() { UnitMeasurementId = 5, Name = "Energy", Simbol = "kWh" });

            context.SaveChanges();

            //context.Controllers.AddOrUpdate(new Domain.Controller() { ControllerId = 1, Name = "Arduino_01", Description = "Placa principal",
            //    Metrics = new System.Collections.Generic.List<Domain.Metric>() { new Domain.Metric() { MetricId = 1, Description = "ConsumoBasico", Name = "Consumo 3 f�sica entrada", UnitMeasurement = context.UnitMeasurements.First(e => e.Name == "Ampere") } } });
            
            context.SaveChanges();
            */
        }
    }
}
