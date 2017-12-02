using PowerView.DataAccess.Abstractions;
using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PowerView.DataAccess
{
    public class ControllerRepository : GenericEntityFrameworkRepository<Controller>, IControllerRepository
    {
        #region Constructor

        public ControllerRepository(PowerViewDbContext context) : base(context)
        {
        }
        #endregion

        #region Methods
        #endregion
    }
}
