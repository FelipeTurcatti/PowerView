using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PowerView.Web.UI.Controllers
{
    /// <summary>
    /// PowerView's main Controller.-
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Main action.-
        /// </summary>
        /// <returns>Main View</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Flow charts action.-
        /// </summary>
        /// <returns>Flow chart's partial view</returns>
        public ActionResult FlotCharts()
        {
            return View("FlotCharts");
        }

        /// <summary>
        /// Morris charts action.-
        /// </summary>
        /// <returns>Morris chart's partial view</returns>
        public ActionResult MorrisCharts()
        {
            return View("MorrisCharts");
        }

        /// <summary>
        /// Tables action.-
        /// </summary>
        /// <returns>Tables's partial view</returns>
        public ActionResult Tables()
        {
            return View("Tables");
        }

        /// <summary>
        /// Forms action.-
        /// </summary>
        /// <returns>Forms's partial view</returns>
        public ActionResult Forms()
        {
            return View("Forms");
        }

        /// <summary>
        /// Panels action.-
        /// </summary>
        /// <returns>Panels's partial view</returns>
        public ActionResult Panels()
        {
            return View("Panels");
        }

        /// <summary>
        /// Buttons action.-
        /// </summary>
        /// <returns>Botton's partial view</returns>
        public ActionResult Buttons()
        {
            return View("Buttons");
        }

        /// <summary>
        /// Notification action.-
        /// </summary>
        /// <returns>Notification's partial view</returns>
        public ActionResult Notifications()
        {
            return View("Notifications");
        }

        /// <summary>
        /// Typography action.-
        /// </summary>
        /// <returns>Typography's partial view</returns>
        public ActionResult Typography()
        {
            return View("Typography");
        }

        /// <summary>
        /// Icons action.-
        /// </summary>
        /// <returns>Icons's partial view</returns>
        public ActionResult Icons()
        {
            return View("Icons");
        }

        /// <summary>
        /// Grid action.-
        /// </summary>
        /// <returns>Grid's partial view</returns>
        public ActionResult Grid()
        {
            return View("Grid");
        }

        /// <summary>
        /// Blank action.-
        /// </summary>
        /// <returns>Blank's partial view</returns>
        public ActionResult Blank()
        {
            return View("Blank");
        }

        /// <summary>
        /// Login action.-
        /// </summary>
        /// <returns>Login's partial view</returns>
        public ActionResult Login()
        {
            return View("Login");
        }

    }
}