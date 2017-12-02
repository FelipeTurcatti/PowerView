using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PowerView.Web.UI.Controllers
{
    /// <summary>
    /// Manage System's metric controllers
    /// </summary>
    public class MonitoringController : Controller
    {
        /// <summary>
        /// MVC Main view.-
        /// </summary>
        /// <returns></returns>
        // GET: Monitoring
        public ActionResult Index()
        {
            return View();
        }
    }
}