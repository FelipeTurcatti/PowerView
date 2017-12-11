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

            Domain.UnitMeasurement noUnit = new Domain.UnitMeasurement() { UnitMeasurementId = 1, Name = "N/A", Simbol = String.Empty };

            Domain.UnitMeasurement volt = new Domain.UnitMeasurement() { UnitMeasurementId = 2, Name = "Volt", Simbol = "V" };

            Domain.UnitMeasurement watt = new Domain.UnitMeasurement() { UnitMeasurementId = 3, Name = "Watts", Simbol = "W" };

            Domain.UnitMeasurement ampere = new Domain.UnitMeasurement() { UnitMeasurementId = 4, Name = "Ampere", Simbol = "I" };

            Domain.UnitMeasurement hertz = new Domain.UnitMeasurement() { UnitMeasurementId = 5, Name = "Hertz", Simbol = "Hz" };

            Domain.UnitMeasurement energy = new Domain.UnitMeasurement() { UnitMeasurementId = 6, Name = "Energy", Simbol = "kWh" };

            Domain.UnitMeasurement voltAmpere = new Domain.UnitMeasurement() { UnitMeasurementId = 7, Name = "Volt-Ampere", Simbol = "VA" };

            context.UnitMeasurements.AddOrUpdate(noUnit);

            context.UnitMeasurements.AddOrUpdate(volt);

            context.UnitMeasurements.AddOrUpdate(watt);

            context.UnitMeasurements.AddOrUpdate(ampere);

            context.UnitMeasurements.AddOrUpdate(hertz);

            context.UnitMeasurements.AddOrUpdate(energy);

            context.UnitMeasurements.AddOrUpdate(voltAmpere);

            context.SaveChanges();

            context.Controllers.AddOrUpdate(new Domain.Controller()
            {
                ControllerId = 1,
                Name = "Arduino_01",
                Description = "Placa principal",
                Metrics = new System.Collections.Generic.List<Domain.Metric>() { new Domain.Metric() { MetricId = 1, Description = "Consumo", Name = "Consumo trifásica fásica entrada", UnitMeasurement = energy} }
            });

            context.SaveChanges();

        }
    }
}
