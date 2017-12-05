using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PowerView.Domain;

namespace PowerView.DataAccess.Abstractions
{
    public interface IMetricRepository
    {

        IEnumerable<Metric> Get(
             Expression<Func<Metric, Boolean>> filter = null,
             Func<IQueryable<Metric>, IOrderedQueryable<Metric>> orderBy = null,
             String includeProperties = "");

        Metric GetByID(Object id);

        void Insert(Metric controller);

        void Update(Metric controller);

        void Delete(Metric controller);
    }
}
