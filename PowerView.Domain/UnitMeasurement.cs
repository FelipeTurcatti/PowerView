using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain
{
    public class UnitMeasurement 
    {
        [Key]
        [Column(Order = 10)]
        [Display(Name = "ID")]
        public Int32 UnitMeasurementId { get; set; }

       
        [Column(Order = 20)]
        [Display(Name = "Nombre")]
        [MaxLength(50)]
        public String Name { get; set; }

      
        [Column(Order = 30)]
        [Display(Name = "Símbolo")]
        [MaxLength(5)]
        public String Simbol { get; set; }

        public ICollection<Metric> Metrics { get; set; }

    }
}
