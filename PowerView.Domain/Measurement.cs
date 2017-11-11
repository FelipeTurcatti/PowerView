using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain
{
    public class Measurement: Entity
    {
        public String SensorId { get; set; }

        public Int32 MeasurementUnitId { get; set; }

        public Double Value { get; set; }

        public DateTime CreationDate { get; set; }
    }    
}
