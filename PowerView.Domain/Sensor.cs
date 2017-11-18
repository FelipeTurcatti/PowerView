using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain
{
    public class Sensor 
    {
        [Required]
        public int SensorId { get; set; }

        [MaxLength(200)]
        [Required]
        public String Name { get; set; }

        [MaxLength(200)]
        [Required]
        public String Description { get; set; }  

        public String Location { get; set; }

        public String Note { get; set; }

        public List<UnitMeasurement> UnitMeasurementList { get; set; }
    }
}
