using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain.Logic.Interface
{
    public interface IMeasurementService
    {
        Double PullData(String controllerName, String metricName);
    }
}
