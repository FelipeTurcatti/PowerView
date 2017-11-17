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
            return base.Get().ToList();
        }

        public Sensor Get(int sensorID)
        {
            return base.Get(x => x.SensorId==sensorID).FirstOrDefault();
        }
        #endregion
    }
}
