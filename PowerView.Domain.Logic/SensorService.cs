using PowerView.DataAccess.Abstractions;
using PowerView.Domain.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain.Logic
{
    public class SensorService : ISensorService
    {
        private readonly ISensorRepository _SensorRepository;

        #region Constructor
        public SensorService(ISensorRepository sensorRepository)
        {
            this._SensorRepository = sensorRepository;
        }
        #endregion

        public Sensor GetSensor(int sensorID)
        {
            return this._SensorRepository.Get(sensorID);
        }

        public IList<Sensor> GetSensors()
        {
            return this._SensorRepository.Get();
        }
    }
}
