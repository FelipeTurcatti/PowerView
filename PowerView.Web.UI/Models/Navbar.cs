using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerView.Web.UI.Models
{
    /// <summary>
    /// Represent the Navigation model
    /// </summary>
    public class Navbar
    {
        /// <summary>
        /// Get or set the Navigation item's Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get or set the Navigation item's option name
        /// </summary>
        public string nameOption { get; set; }

        /// <summary>
        /// Get or set the Navigation item's MVC Controller
        /// </summary>
        public string controller { get; set; }

        /// <summary>
        /// Get or set the Navigation item's mvc action
        /// </summary>
        public string action { get; set; }

        /// <summary>
        /// Get or set the Navigation item's Area
        /// </summary>
        public string area { get; set; }

        /// <summary>
        /// Get or set the Navigation item's image css class
        /// </summary>
        public string imageClass { get; set; }

        /// <summary>
        /// Get or set the Navigation item's activeli
        /// </summary>
        public string activeli { get; set; }

        /// <summary>
        /// Get or set the Navigation item's status
        /// </summary>
        public bool status { get; set; }

        /// <summary>
        /// Get or set the Navigation item's Parent id
        /// </summary>
        public int parentId { get; set; }

        /// <summary>
        /// Get or set if it's a Parent Items.-
        /// </summary>
        public bool isParent { get; set; }
    }
}