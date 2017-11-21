using PowerView.Domain.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PowerView.Web.Api.Controllers
{
    /// <summary>
    /// Supports CRUD operations related to a set of Sensors.-
    /// </summary>
    public class SensorController : ApiController
    {
        private ISensorService _sensorService;

        #region Constructor
        /// <summary>
        /// Supports CRUD operations related to a set of Sensors.-
        /// </summary>
        /// <param name="sensorService"></param>
        public SensorController(ISensorService sensorService)
        {
            this._sensorService = sensorService;
        }
        #endregion

        #region Methods
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
            var sensors = this._sensorService.GetSensors();
            return Ok(sensors);
        }

        
        /// <summary>
        /// Get sensor by ID
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>        
        /// <returns>A sensor</returns>
        [HttpGet]
        [Route("api/Sensor/{sensorID}")]
        public IHttpActionResult Get(Int32 sensorID)
        {
            var sensor = this._sensorService.GetSensor(sensorID);
            return Ok(sensor);
        }

        
        #endregion
    }
}
