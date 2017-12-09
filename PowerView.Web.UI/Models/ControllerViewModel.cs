using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PowerView.Domain;

namespace PowerView.Web.UI.Models
{
    public class ControllerViewModel
    {
        #region Members
        public PowerView.Domain.Controller _controller { get; set; }
       
        public IEnumerable<Metric> _metrics { get; set; }

        public String metricID { get; set; }

        #endregion

        #region Contructor
        public ControllerViewModel()
        {
            this._controller = new PowerView.Domain.Controller();          
        }
        #endregion

    }
}