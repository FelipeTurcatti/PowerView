using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerView.DataAccess.Abstractions;
using PowerView.Domain.Logic.Interface;

namespace PowerView.Domain.Logic
{
    public class UnitMeasurementService : IUnitMeasurementService
    {
        private readonly IUnitMeasurementRepository _umRepository;

        #region Constructor

        public UnitMeasurementService(IUnitMeasurementRepository umRepository)
        {
            this._umRepository = umRepository;
        }
        #endregion

        public IEnumerable<UnitMeasurement> Get()
        {
            return this._umRepository.Get();
        }
    }
}
