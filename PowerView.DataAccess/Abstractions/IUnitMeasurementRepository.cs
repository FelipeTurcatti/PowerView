using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PowerView.Domain;

namespace PowerView.DataAccess.Abstractions
{
    public interface IUnitMeasurementRepository
    {
        IEnumerable<UnitMeasurement> Get(
            Expression<Func<UnitMeasurement, Boolean>> filter = null,
            Func<IQueryable<UnitMeasurement>, IOrderedQueryable<UnitMeasurement>> orderBy = null,
            String includeProperties = "");

    }
}
