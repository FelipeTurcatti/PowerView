using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.DataAccess.MongoDB
{
    public class Measurement
    {
        public ObjectId Id { get; set; }
        public String IdSensor { get; set; }
        public Int32 IdUnitOfMeasurement { get; set; }
        public Double QuantityMeasured { get; set; }
        public DateTime CreationDate { get; set; }
    }

    
}
