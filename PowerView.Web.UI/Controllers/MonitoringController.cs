using PowerView.Domain.Logic.Interface;
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

        #region Members

        private readonly IControllerService _controllerService;

        #endregion

        #region Constructor

        public MonitoringController(IControllerService controllerService)
        {
            this._controllerService = controllerService;
        }

        #endregion

        /// <summary>
        /// MVC Main view.-
        /// </summary>
        /// <returns></returns>
        // GET: Monitoring
        public ActionResult Index()
        {
            IEnumerable<PowerView.Domain.Controller> controllers = this._controllerService.Get();

            return View(controllers);
        }             
    }
}