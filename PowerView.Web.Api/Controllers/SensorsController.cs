using PowerView.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace PowerView.Web.Api.Controllers
{
  public class SensorsController : ApiController
  {
    Sensor[] sensors = new Sensor[]
    {
      new Sensor { Name = "S1", Description = "Sensor 1" },
      new Sensor { Name = "S2", Description = "Sensor 2" },
      new Sensor { Name = "S3", Description = "Sensor 3" }
    };

    public IEnumerable<Sensor> GetAllSensors()
    {
      return sensors;
    } 
  }
}
