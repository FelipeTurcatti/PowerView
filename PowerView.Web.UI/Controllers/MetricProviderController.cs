using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PowerView.Domain.Logic.Interface;

namespace PowerView.Web.UI.Controllers
{
    /// <summary>
    /// Provides metric values for any controller.-
    /// </summary>
    public class MetricProviderController : ApiController
    {
        private readonly IMeasurementService _measurementService;

        public MetricProviderController(IMeasurementService measurementService)
        {
            this._measurementService = measurementService;
        }
        /// <summary>
        /// Get the last metric value for a specified controller
        /// </summary>      
        /// <returns>The lates value.-</returns>
        [HttpPost]
        [Route("api/metricProvider/pull")]
        public IHttpActionResult PullData()
        {

            Double value = this._measurementService.PullData("Arduino_01", "PotenciaEntregada");


            return this.Ok(value);
        }

        /// <summary>
        /// Get the last metric value for a specified controller
        /// </summary>
        /// <param name="controllerID">Controller identifier</param>
        /// <param name="metricName">Metric identifier</param>
        /// <returns>The lates value.-</returns>
        [HttpPost]
        [Route("api/metricProvider/pull/{controllerID}/{metricName}")]
        public IHttpActionResult PullData(String controllerID, String metricName)
        {
            Double value = this._measurementService.PullData(controllerID, metricName);

            return this.Ok(value);
        }        
    }
}