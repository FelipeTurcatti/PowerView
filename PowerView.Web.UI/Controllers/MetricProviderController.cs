using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PowerView.Web.UI.Controllers
{
    /// <summary>
    /// Provides metric values for any controller.-
    /// </summary>
    public class MetricProviderController : ApiController
    {

        /// <summary>
        /// Get the last metric value for a specified controller
        /// </summary>      
        /// <returns>The lates value.-</returns>
        [HttpPost]
        [Route("api/metricProvider/pull")]
        public IHttpActionResult PullData()
        {
            var rnd = new Random();

            return this.Ok(rnd.NextDouble() * 100);
        }

        /// <summary>
        /// Get the last metric value for a specified controller
        /// </summary>
        /// <param name="controllerId">Controller identifier</param>
        /// <param name="metricId">Metric identifier</param>
        /// <returns>The lates value.-</returns>
        [HttpPost]
        [Route("api/metricProvider/pull/{controllerID:int}/{metricId:int}")]
        public IHttpActionResult PullData(Int32 controllerId, Int32 metricId)
        {
            var rnd = new Random();

            return this.Ok(rnd.NextDouble() * 100);
        }        
    }
}