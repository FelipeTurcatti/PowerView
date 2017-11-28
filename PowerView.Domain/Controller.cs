using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain
{
    public class Controller
    {
        [Required]
        public Int32 ControllerId { get; set; }

        [MaxLength(200)]
        [Required]
        public String Name { get; set; }

        [MaxLength(200)]
        public String Description { get; set; }
        
        [Required]
        public List<Metric> Metrics { get; set; }
    }
}
