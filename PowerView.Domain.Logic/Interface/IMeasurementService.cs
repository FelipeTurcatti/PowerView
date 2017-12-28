using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerView.Common;

namespace PowerView.Domain.Logic.Interface
{
    public interface IMeasurementService
    {
        Double PullData(String controllerName, String metricName);

        IEnumerable<DataPoint> GetDataPointValues(int controllerIdSelected, int metricIdSelected, DateTime timeRangeFrom, DateTime timeRangeTo, String frecuency);
    }
}
