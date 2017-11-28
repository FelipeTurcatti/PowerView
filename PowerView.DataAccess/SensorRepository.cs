using PowerView.DataAccess.Abstractions;
using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IList<Controller> Get()
        {
            return base.Get().ToList();
        }

        public Controller Get(Int32 controllerID)
        {
            return base.Get(x => x.ControllerId == controllerID).FirstOrDefault();
        }

        #endregion
    }
}
