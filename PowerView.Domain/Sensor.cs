using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain
{
    public class Sensor 
    {
        public int SensorId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Location { get; set; }
        public List<UnitMeasurement> UnitMeasurementList { get; set; }
    }
}
