using PowerView.DataAccess.Abstractions;
using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.DataAccess
{
    public class SensorRepository : GenericEntityFrameworkRepository<Sensor>, ISensorRepository
    {
        #region Constructor
        public SensorRepository(PowerViewDbContext context) : base(context)
        {
        }
        #endregion

        #region Methods
        public IList<Sensor> Get()
        {
            return this.Get().ToList();
        }

        public Sensor Get(int sensorID)
        {
            return this.Get(x => x.SensorId==sensorID).FirstOrDefault();
        }
        #endregion
    }
}
