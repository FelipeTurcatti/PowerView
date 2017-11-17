using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain.Logic.Interface
{
    public interface ISensorService
    {
        Sensor GetSensor(Int32 sensorID);

        IList<Sensor> GetSensors();
    }
}
