using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PowerView.Web.UI.Controllers
{
    /// <summary>
    /// Sensor administration controller.-
    /// </summary>
    public class SensorAdminController : Controller
    {
        /// <summary>
        /// Main view.-
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }        

    }
}