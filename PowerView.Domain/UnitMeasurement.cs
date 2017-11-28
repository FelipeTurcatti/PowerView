using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain
{
    public class UnitMeasurement 
    {        
        public Int32 UnitMeasurementId { get; set; }

        [MaxLength(50)]
        public String Name { get; set; }

        [MaxLength(5)]
        public String Simbol { get; set; }
        
    }
}
