using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.DataAccess.Abstractions
{
    public interface ISensorRepository
    {
        Sensor Get(Int32 sensorID);

        IList<Sensor> Get();
    }
}
