using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Infrastructure
{
    public class Configuration : IConfiguration
    {
        public String MeasurementTopic
        {
            get
            { 
                return ConfigurationManager.AppSettings["MeasurementTopic"];
            }
        }
    }
}
