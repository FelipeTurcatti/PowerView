using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain
{
    public class Metric 
    {
        [Required]
        public int MetricId { get; set; }

        [MaxLength(200)]
        [Required]
        public String Name { get; set; }

        [MaxLength(200)]
        [Required]
        public String Description { get; set; }
        
        [Required]
        public UnitMeasurement UnitMeasurement { get; set; }
       
        public Controller Controller { get; set; }

    }
}
