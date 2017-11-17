using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PowerView.Web.Api.Controllers
{
    public class SensorController : ApiController
    {
        /// <summary>
        /// Gets the list of sensors
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>        
        /// <returns>A list of sensors</returns>
        [HttpGet]
        [Route("api/Sensor")]
        public IHttpActionResult Get()
        {
            return Ok();
        }

        // GET: api/Sensor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sensor
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sensor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sensor/5
        public void Delete(int id)
        {
        }
    }
}
