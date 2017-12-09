using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain
{
    [Serializable]
    public class Controller
    {
        public Controller()
        {
            this.Metrics = new HashSet<Metric>();
        }

        [Key]
        [Column(Order = 10)]
        [Display(Name = "ID")]
        [Required]
        public Int32 ControllerId { get; set; }

        [Column(Order = 20)]
        [Display(Name = "Nombre")]
        [MaxLength(100)]        
        [Required(ErrorMessage = "Nombre obligatoria")]
        public String Name { get; set; }

        [Column(Order = 30)]
        [Display(Name = "Descripción")]
        [MaxLength(250)]        
        [Required(ErrorMessage = "Descripción obligatoria")]
        public String Description { get; set; }


        public virtual ICollection<Metric> Metrics { get; set; }
    }
}
