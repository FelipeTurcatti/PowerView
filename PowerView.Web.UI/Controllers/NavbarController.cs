using PowerView.Web.UI.Domain;
using PowerView.Web.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PowerView.Web.UI.Controllers
{
    /// <summary>
    /// Navigation controller
    /// </summary>
    public class NavbarController : Controller
    {
        /// <summary>
        /// Get Nav bar.-
        /// </summary>
        /// <returns>Navigation bar's partial view.-</returns>
        public ActionResult Index()
        {
            var data = new Menu();
            return PartialView("_Navbar", data.navbarItems().ToList());
        }
    }
}