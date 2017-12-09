using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PowerView.Domain.Logic.Interface;

namespace PowerView.Web.UI.Controllers
{
    public class MetricAdminController : Controller
    {
        #region Members

        private readonly IMetricService _metricService;
        private readonly IUnitMeasurementService _unitMeasurementService;

        #endregion
        #region Constructo

        /// <summary>
        /// Supports Admin operations related to a set of metrics-
        /// </summary>
        /// <param name="metricService"></param>
        /// <param name="unitMeasurementService"></param>
        public MetricAdminController(IMetricService metricService, IUnitMeasurementService unitMeasurementService)
        {
            this._metricService = metricService;
            this._unitMeasurementService = unitMeasurementService;
        }
        #endregion

        #region Methods

        public ActionResult Index()
        {
            var allMetrics = this._metricService.Get();

            return View(allMetrics);
        }

        /// <summary>
        /// GET: MetricAdmin/Details/5
        /// </summary>
        /// <returns></returns>
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PowerView.Domain.Metric metric = this._metricService.GetByID((int)id);

            if (metric == null)
            {
                return HttpNotFound();
            }
            return View(metric);
        }

        /// <summary>
        /// GET: MetricAdmin/Create
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            ViewBag.UnitMeasurement = this._unitMeasurementService.Get();
            return View();
        }

        /// <summary>
        /// POST: MetricAdmin/Create      
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PowerView.Domain.Metric metricInstance)
        {           
            if (ModelState.IsValid)
            {
              
                this._metricService.Insert(metricInstance);

                TempData["Errores"] = "Creación exitosa";

                return RedirectToAction("Index");
            }

            return View(metricInstance);
        }

        /// <summary>
        /// GET: MetricAdmin/Edit/5
        /// </summary>
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PowerView.Domain.Metric metric = this._metricService.GetByID((int)id);            

            if (metric == null)
            {
                return HttpNotFound();
            }

            ViewBag.UnitMeasurement = this._unitMeasurementService.Get();

            return View(metric);
        }

        // POST: MetricAdmin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PowerView.Domain.Metric metricInstance)
        {
            // ViewData.ModelState.Values

            if (ModelState.IsValid)
            {
                this._metricService.Update(metricInstance);

                TempData["Errores"] = "Modificación exitosa";

                return RedirectToAction("Index");
            }


            return View(metricInstance);
        }

        // GET: MetricAdmin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PowerView.Domain.Metric metric = this._metricService.GetByID((int)id);
            if (metric == null)
            {
                return HttpNotFound();
            }
            return View(metric);
        }

        // POST: MetricAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PowerView.Domain.Metric metric = this._metricService.GetByID((int)id);
            this._metricService.Delete(metric);

            TempData["Errores"] = "Eliminación exitosa";

            return RedirectToAction("Index");
        }
        #endregion
    }
}