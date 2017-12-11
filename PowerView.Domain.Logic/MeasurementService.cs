using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain.Logic.Interface;

namespace PowerView.Domain.Logic
{
    public class MeasurementService: IMeasurementService
    {
        private readonly IMeasurementRepository _measurementRepository;

        public MeasurementService(IMeasurementRepository measurementRepository)
        {
            this._measurementRepository = measurementRepository;
        }
        /// <summary>
        /// Gets the last measurement value for the controller and metric
        /// </summary>
        /// <param name="controllerId"></param>
        /// <param name="metricId"></param>
        /// <returns></returns>
        public Double PullData(String controllerName, String metricName)
        {
            var mesure = this._measurementRepository
                .Where(e => e.ControllerName == controllerName && e.MetricName == metricName).AsQueryable()
                .OrderByDescending(l => l.CreationDate).First();

           
            return mesure.Value;
        }

    }
}
