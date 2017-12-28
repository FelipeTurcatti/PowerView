using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerView.Common;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain.Logic.Interface;

namespace PowerView.Domain.Logic
{
    public class MeasurementService: IMeasurementService
    {
        private readonly IMeasurementRepository _measurementRepository;

        private readonly IControllerRepository _controllerRepository;

        private readonly IMetricService _metricRepository;

        public MeasurementService(IMeasurementRepository measurementRepository, IControllerRepository controllerRepository, IMetricService metricRepository)
        {
            this._measurementRepository = measurementRepository;
            this._controllerRepository = controllerRepository;
            this._metricRepository = metricRepository;
        }

        /// <summary>
        /// Gets the last measurement value for the controller and metric
        /// </summary>
        /// <param name="controllerId"></param>
        /// <param name="metricId"></param>
        /// <returns></returns>
        public Double PullData(String controllerName, String metricName)
        {
            var measure = this._measurementRepository
                .Where(e => e.ControllerName == controllerName && e.MetricName == metricName).AsQueryable()
                .OrderByDescending(l => l.CreationDate).FirstOrDefault();


            if (null != measure)
                return measure.Value;
            else
                return 0;
        }

        public IEnumerable<DataPoint> GetDataPointValues(int controllerId, int metricId, DateTime timeRangeFrom, DateTime timeRangeTo, String frequency)
        {
            List<DataPoint> data = new List<DataPoint>();

            Controller controller = this._controllerRepository.GetByID(controllerId);
            Metric metric = this._metricRepository.GetByID(metricId);

            List<Measurement> result = this._measurementRepository
           .Where(e => e.ControllerName == controller.Name && e.MetricName == metric.Name && e.CreationDate >= timeRangeFrom && e.CreationDate <= timeRangeTo)
           .OrderBy(o=>o.CreationDate).ToList();
            
            
            switch (frequency)
            {
                case "Diaria":
                    data = GetGroupByDate(result);
                    break;                
                case "Mensual":
                    data = GetGroupByMonth(result);
                    break;
                case "Anual":
                    data = GetGroupByYear(result);
                    break;
                default:
                    // Data point (Y=value, X axis => datetime)
                    result.ForEach(e => data.Add(new DataPoint(e.Value, e.CreationDate.ToLocalTime().ToString("dd/MM/yyyy HH:mm"))));
                    break;
            }
            return data;
        }

        private List<DataPoint> GetGroupByYear(List<Measurement> result)
        {
            List<DataPoint> data = new List<DataPoint>();
            IEnumerable<IGrouping<Int32, Measurement>> groupByYear = result.GroupBy(e => e.CreationDate.ToLocalTime().Year);

            foreach (IGrouping<Int32, Measurement> dateGroup in groupByYear)
            {
                Int32 year = dateGroup.Key;
                var value = dateGroup.Sum(e => e.Value);

                data.Add(new DataPoint(value, ""+ year));

            }

            return data;
        }

        private List<DataPoint> GetGroupByMonth(List<Measurement> result)
        {
            List<DataPoint> data = new List<DataPoint>();

            var grupByMonthYear = result.GroupBy(o => new
            {
                Month = o.CreationDate.Month,
                Year = o.CreationDate.Year              
            });

            foreach (var dateGroup in grupByMonthYear)
            {
                String yearMonth = dateGroup.Key.Year + " - " + dateGroup.Key.Month;
                var value = dateGroup.Sum(e => e.Value);

                data.Add(new DataPoint(value,  yearMonth));
            }
            return data;
        }

        private List<DataPoint> GetGroupByDate(List<Measurement> result)
        {
            List<DataPoint> data = new List<DataPoint>();
            IEnumerable<IGrouping<DateTime,Measurement>> groupByDate = result.GroupBy(e => e.CreationDate.ToLocalTime().Date);
            
            foreach (IGrouping<DateTime,Measurement> dateGroup in groupByDate)
            {
                DateTime day = dateGroup.Key;
                var value = dateGroup.Sum(e => e.Value);

                data.Add(new DataPoint(value, day.ToString("dd/MM/yyyy")));

            }

            return data;
        }
    }
}
