using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PowerView.Domain.Logic;
using PowerView.Domain.Logic.Interface;
using PowerView.Web.UI.Models;

namespace PowerView.Web.UI.Controllers
{
    /// <summary>
    /// controller administration controller.-
    /// </summary>
    public class ControllerAdminController : Controller
    {
        #region Members

        private readonly IControllerService _controllerService;
        private readonly IMetricService _metricService;

        #endregion

        #region Constructor

        /// <summary>
        /// Supports Admin operations related to a set of controllers.-
        /// </summary>
        /// <param name="controllerService"></param>
        /// <param name="metricService"></param>
        public ControllerAdminController(IControllerService controllerService, IMetricService metricService)
        {
            this._controllerService = controllerService;
            this._metricService = metricService;
        }
        #endregion

        /// <summary>
        /// GET: ControllersAdmin
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var allControllers  = this._controllerService.Get();

            return View(allControllers);
        }

        /// <summary>
        /// GET: ControllersAdmin/Details/5
        /// </summary>
        /// <returns></returns>
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PowerView.Domain.Controller controller = this._controllerService.GetByID((int)id);

            if (controller == null)
            {
                return HttpNotFound();
            }

            ControllerViewModel model = new ControllerViewModel();
            model._controller = controller;

            return View(model);
        }

        /// <summary>
        /// GET: ControllersAdmin/Create
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            ControllerViewModel model = new ControllerViewModel();
           
            return View(model);
        }

        /// <summary>
        /// POST: ControllerAdmin/Create
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PowerView.Web.UI.Models.ControllerViewModel model)
        {
            if (ModelState.IsValid)
            {
               
                this._controllerService.Insert(model._controller);

                TempData["Errores"] = "Creación exitosa";

                return RedirectToAction("Index");
            }

            return View(model);
        }
        
        /// <summary>
        /// GET: ControllerAdmin/Edit/5
        /// </summary>
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ControllerViewModel model = new ControllerViewModel();
            PowerView.Domain.Controller controller = this._controllerService.GetByID((int)id);
            model._controller = controller;
            if (controller == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
       
        /// <summary>
        /// POST: ControllerAdmin/Edit/5 
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PowerView.Web.UI.Models.ControllerViewModel model)
        {
            // ViewData.ModelState.Values

            if (ModelState.IsValid)
            {               
                this._controllerService.Update(model._controller);

                TempData["Errores"] = "Modificación exitosa";

                return RedirectToAction("Index");
            }


            return View(model);
        }
    
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PowerView.Domain.Controller controller = this._controllerService.GetByID((int)id);
            if (controller == null)
            {
                return HttpNotFound();
            }
            return View(controller);
        }
                  
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PowerView.Domain.Controller controller = this._controllerService.GetByID((int)id);
            this._controllerService.Delete(controller);

            TempData["Errores"] = "Eliminación exitosa";

            return RedirectToAction("Index");
        }
               
        public ActionResult ShowMetrica(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ControllerViewModel model = new ControllerViewModel();
            PowerView.Domain.Controller controller = this._controllerService.GetByID((int)id);
            model._controller = controller;
            model._metrics = this._metricService.Get();

            if (controller == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult ShowMetrica(ControllerViewModel model)
        {   
            // Valida Metrica
            PowerView.Domain.Metric metricExist = this._metricService.GetByID(Int32.Parse(model.metricID));
            if (metricExist == null)
            {
                TempData["Errores"] = "La métrica no existe";
                return View("ShowMetrica", model);
            }

            // Valida si la controladora tiene la metrica
            PowerView.Domain.Controller controller = this._controllerService.GetByID(model._controller.ControllerId);
            PowerView.Domain.Metric metric = controller.Metrics.FirstOrDefault(e => e.MetricId.ToString() == model.metricID);            
            if (metric != null)
            {
                TempData["Errores"] = "La metrica seleccionada ya existe en la controladora.";                
            }
            else
            {
                this._controllerService.AddMetricController(model._controller.ControllerId,Int32.Parse(model.metricID));
                TempData["Errores"] = "La métrica se ha agregado de forma exitosa";
                controller.Metrics.Add(metricExist);                
            }

            model._controller = controller;
            model._metrics = this._metricService.Get();

          
            return View("ShowMetrica",model);
        }
        public ActionResult DeleteMetric(int? idController,int? idMetrica)
        {
            if (idController == null && idMetrica == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PowerView.Domain.Controller controller = this._controllerService.GetByID(idController.Value);
            PowerView.Domain.Metric metric = controller.Metrics.FirstOrDefault(e => e.MetricId == idMetrica.Value);
            if (metric == null)
            {
                TempData["Errores"] = "La métrica no existe en la controladora.";
            }
            else
            {
                this._controllerService.RemoveMetricController(idController.Value, idMetrica.Value);
                TempData["Errores"] = "La métrica se ha eliminado de la controladora de forma exitosa";
                controller.Metrics.Remove(metric);
            }

            ControllerViewModel model = new ControllerViewModel();
            model._controller = controller;
            model._metrics = this._metricService.Get();
            return View(model);
        }
    }
}