using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain.Logic.Interface;

namespace PowerView.Domain.Logic
{
    public class MetricService : IMetricService
    {
        private readonly IMetricRepository _metricRepository;

        #region Constructor

        public MetricService(IMetricRepository metricRepository)
        {
            this._metricRepository = metricRepository;
        }

        #endregion

        public IEnumerable<Metric> Get()
        {
            return this._metricRepository.Get();
        }

        public Metric GetByID(Int32 metricID)
        {
            return this._metricRepository.GetByID(metricID);
        }

        public void Insert(Metric metric)
        {
            this._metricRepository.Insert(metric);

        }

        public void Update(Metric metric)
        {
            this._metricRepository.Update(metric);

        }

        public void Delete(Metric metric)
        {
            this._metricRepository.Delete(metric);

        }
    }
}
