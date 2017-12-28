using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using PowerView.Common;
using PowerView.Domain.Logic.Interface;
using PowerView.Web.UI.Models;

namespace PowerView.Web.UI.Controllers
{
    public class ReportController : Controller
    {
        #region Members

        private readonly IControllerService _controllerService;
        private readonly IMeasurementService _measurementService;
        #endregion

        #region Constructor
        public ReportController(IControllerService controllerService, IMeasurementService measurementService) {
            this._controllerService = controllerService;
            this._measurementService = measurementService;
        }
        #endregion

        #region Methods

        [HttpGet]
        public ActionResult Index()
        {
            ReportViewModel controlerVM = new ReportViewModel();

            // Set all system controllers
            controlerVM.AllControllers = this._controllerService.Get();

            // Set Default controller
            controlerVM.ControllerSelected = controlerVM.AllControllers.First();
            controlerVM.ControllerIdSelected = controlerVM.ControllerSelected.ControllerId;

            // Set Default metric
            controlerVM.MetricIdSelected = controlerVM.ControllerSelected.Metrics.First().MetricId;

            // Set Default Time Range
            controlerVM.TimeRangeFrom = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,0,0,0);
            controlerVM.TimeRangeTo = controlerVM.TimeRangeFrom.AddDays(1);

            // Set Frecuency
            controlerVM.AllFrequency = Frequency.GetFrecuency();

            return View(controlerVM);
        }

        [HttpPost]        
        public ActionResult Index(ReportViewModel controlerVM)
        {
            // Set all system controllers
            controlerVM.AllControllers = this._controllerService.Get();

            // Set controller selected
            controlerVM.ControllerSelected = controlerVM.AllControllers.Where(e => e.ControllerId == controlerVM.ControllerIdSelected).FirstOrDefault();

            controlerVM.ControllerName = controlerVM.ControllerSelected.Description;

            controlerVM.MetricName = controlerVM.ControllerSelected.Metrics.Where(e=> e.MetricId == controlerVM.MetricIdSelected).FirstOrDefault().Description;

            controlerVM.UM = controlerVM.ControllerSelected.Metrics.Where(e => e.MetricId == controlerVM.MetricIdSelected).FirstOrDefault().UnitMeasurement.Simbol;

            if(controlerVM.FrequencySelected == null)
                controlerVM.Grafico = "area";
            else
                controlerVM.Grafico = "column";
            return View("Chart", controlerVM);
        }

       
        public ContentResult Json(ReportViewModel controlerVM)
        {
            IEnumerable<DataPoint> dataPoints = this._measurementService.GetDataPointValues(controlerVM.ControllerIdSelected, controlerVM.MetricIdSelected,controlerVM.TimeRangeFrom,controlerVM.TimeRangeTo, controlerVM.FrequencySelected);

            JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

            return Content(JsonConvert.SerializeObject(dataPoints, _jsonSetting), "application/json");
        }
       
        #endregion
    }
}