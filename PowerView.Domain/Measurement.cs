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
        [System.Runtime.Serialization.DataMemberAttribute]
        public String ControllerId { get; set; }

        [System.Runtime.Serialization.DataMemberAttribute]
        public Int32 UnitMeasurementId { get; set; }

        [System.Runtime.Serialization.DataMemberAttribute]
        public Double Value { get; set; }

        [System.Runtime.Serialization.DataMemberAttribute]
        public DateTime CreationDate { get; set; }
    }
}
