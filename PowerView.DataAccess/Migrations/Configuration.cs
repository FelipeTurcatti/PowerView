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
        }
    }
}
