using PowerView.Domain.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PowerView.Web.UI.Controllers
{
    /// <summary>
    /// Supports CRUD operations related to a set of controllers.-
    /// </summary>
    public class ControllerController : ApiController
    {

        #region Members

        private readonly IControllerService _controllerService;

        #endregion

        #region Constructor
        /// <summary>
        /// Supports CRUD operations related to a set of controllers.-
        /// </summary>
        /// <param name="controllerService"></param>
        public ControllerController(IControllerService controllerService)
        {
            this._controllerService = controllerService;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Gets the list of controllers
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>        
        /// <returns>A list of controllers</returns>
        [HttpGet]
        [Route("api/Controller")]
        public IHttpActionResult Get()
        {
            var controllers = this._controllerService.GetControllers();
            return Ok(controllers);
        }

        /// <summary>
        /// Get controller by ID
        /// </summary>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>        
        /// <returns>A controller</returns>
        [HttpGet]
        [Route("api/Controller/{controllerID}")]
        public IHttpActionResult Get(Int32 controllerID)
        {
            var controller = this._controllerService.GetController(controllerID);
            return Ok(controllerID);
        }
        
        #endregion

    }
}
