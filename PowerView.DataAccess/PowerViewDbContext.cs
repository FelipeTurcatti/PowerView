using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.DataAccess
{

    public class PowerViewDbContext : DbContext
    {
        public PowerViewDbContext() : base()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<UnitMeasurement> UnitMeasurements { get; set; }     
    }    
}
