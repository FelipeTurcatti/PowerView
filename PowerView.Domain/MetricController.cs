using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain
{
    public class MetricController
    {
        [Required]
        public int MetricControllerId { get; set; }

        [Required]
        public Controller Controller { get; set; }

        [Required]
        public Metric Metric { get; set; }

    }
}
