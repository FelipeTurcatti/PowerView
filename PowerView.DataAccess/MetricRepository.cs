using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain;

namespace PowerView.DataAccess
{
    public class MetricRepository : GenericEntityFrameworkRepository<Metric>, IMetricRepository
    {
        public MetricRepository(PowerViewDbContext context) : base(context)
        {
        }
    }
}
