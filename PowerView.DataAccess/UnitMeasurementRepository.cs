using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain;

namespace PowerView.DataAccess
{
    public class UnitMeasurementRepository : GenericEntityFrameworkRepository<UnitMeasurement>, IUnitMeasurementRepository
    {
        public UnitMeasurementRepository(PowerViewDbContext context) : base(context)
        {
        }
    }
}
