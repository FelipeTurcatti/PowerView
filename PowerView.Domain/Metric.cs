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
        public Metric()
        {
            this.Controllers = new HashSet<Controller>();
        }

        [Key]
        [Column(Order = 10)]
        [Display(Name = "ID")]
        [Required]
        public int MetricId { get; set; }

        [Column(Order = 20)]
        [Display(Name = "Nombre")]
        [MaxLength(100)]
        [Required]
        public String Name { get; set; }

        [Column(Order = 30)]
        [Display(Name = "Descripción")]
        [MaxLength(250)]
        [Required]
        public String Description { get; set; }

        [Column(Order = 40)]
        [Display(Name = "UM")]   
        [Required]
        public Int32 UnitMeasurementId { get; set; }

        public virtual UnitMeasurement UnitMeasurement { get; set; }

        public virtual ICollection<Controller> Controllers { get; set; }

    }
}
