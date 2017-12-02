using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PowerView.Domain.Logic.Interface;

namespace PowerView.Web.UI.Controllers
{
    /// <summary>
    /// controller administration controller.-
    /// </summary>
    public class ControllerAdminController : Controller
    {
        #region Members

        private readonly IControllerService _controllerService;

        #endregion

        #region Constructor
        
        /// <summary>
        /// Supports Admin operations related to a set of controllers.-
        /// </summary>
        /// <param name="controllerService"></param>
        public ControllerAdminController(IControllerService controllerService)
        {
            this._controllerService = controllerService;
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
            return View(controller);
        }

        /// <summary>
        /// GET: ControllersAdmin/Create
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// POST: ControllerAdmin/Create
        /// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        /// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Description")] PowerView.Domain.Controller controllerInstance)
        {
            if (ModelState.IsValid)
            {
               
                this._controllerService.Insert(controllerInstance);

                TempData["Errores"] = "Creación exitosa";

                return RedirectToAction("Index");
            }

            return View(controllerInstance);
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

            PowerView.Domain.Controller controller = this._controllerService.GetByID((int)id);
            if (controller == null)
            {
                return HttpNotFound();
            }
            return View(controller);
        }

        // POST: ControllerAdmin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ControllerId,Name,Description")] PowerView.Domain.Controller controllerInstance)
        {
            // ViewData.ModelState.Values

            if (ModelState.IsValid)
            {               
                this._controllerService.Update(controllerInstance);

                TempData["Errores"] = "Modificación exitosa";

                return RedirectToAction("Index");
            }


            return View(controllerInstance);
        }

        // GET: ControllerAdmin/Delete/5
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

        // POST: ControllerAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PowerView.Domain.Controller controller = this._controllerService.GetByID((int)id);
            this._controllerService.Delete(controller);

            TempData["Errores"] = "Eliminación exitosa";

            return RedirectToAction("Index");
        }

    }
}