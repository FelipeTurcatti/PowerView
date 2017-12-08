using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using PowerView.Web.UI.Models;

namespace PowerView.Web.UI.Controllers
{
    public class MonitoringController : Controller
    {
        // GET: Monitoring
        public ActionResult Index()
        {
            try
            {
                double count = 50, y = 10;

                Random random = new Random(DateTime.Now.Millisecond);

                List<DataPoint> dataPoints;

                dataPoints = new List<DataPoint>();

                for (int i = 0; i < count; i++)
                {
                    y = y + (random.Next(0, 20) - 10);

                    dataPoints.Add(new DataPoint(i, y));
                }

                JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

                ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints, _jsonSetting);

                return View();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                return View("Error");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return View("Error");
            }
        }

        public ContentResult JSON()
        {
            double count = 50, y = 10;

            Random random = new Random(DateTime.Now.Millisecond);

            List<DataPoint> dataPoints;

            dataPoints = new List<DataPoint>();

            for (int i = 0; i < count; i++)
            {
                y = y + (random.Next(0, 20) - 10);

                dataPoints.Add(new DataPoint(i, y));
            }

            JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

            return Content(JsonConvert.SerializeObject(dataPoints, _jsonSetting), "application/json");
        }

        // GET: HowTo
        public ActionResult DataFromDataBase()
        {
            return View();
        }
    }
}