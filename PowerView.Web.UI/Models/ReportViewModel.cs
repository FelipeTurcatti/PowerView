using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PowerView.Common;

namespace PowerView.Web.UI.Models
{
    public class ReportViewModel
    {
        #region Members
        public IEnumerable<PowerView.Domain.Controller> AllControllers { get; set; }

        public Int32 ControllerIdSelected { get; set; }

        public PowerView.Domain.Controller ControllerSelected { get; set; }

        public Int32 MetricIdSelected { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TimeRangeFrom { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TimeRangeTo { get; set; }
               
        public IEnumerable<String> AllFrequency { get; set; }

        public String FrequencySelected { get; set; }

        public String ControllerName { get; set; }

        public String MetricName { get; set; }

        public String UM { get; set; }

        public String Grafico { get; set; }

        #endregion

        #region Contructor

        public ReportViewModel()
        {
           
        }
        #endregion
    }
     public class Frequency
    {
        public static IEnumerable<String> GetFrecuency()
        {
            List<String> list = new List<string>();
            list.Add("");
            list.Add("Diaria");
            list.Add("Mensual");
            list.Add("Anual");

            return list;
        }
    }
}