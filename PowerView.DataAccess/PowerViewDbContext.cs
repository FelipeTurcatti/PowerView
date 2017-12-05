using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.DataAccess
{

    public class PowerViewDbContext : DbContext
    {
        public PowerViewDbContext() : base("PowerView")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Controller> Controllers { get; set; }

        public DbSet<Metric> Metrics { get; set; }

        public DbSet<UnitMeasurement> UnitMeasurements { get; set; }

        //public DbSet<MetricController> MetricControllers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Controller>()
                .HasMany(up => up.Metrics)
                .WithMany(met => met.Controllers)
                .Map(mc =>
                {
                    mc.ToTable("MetricController");
                    mc.MapLeftKey("Metric_MetricID");
                    mc.MapRightKey("Controller_ControllerID");
                }
            );

            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }    
}
