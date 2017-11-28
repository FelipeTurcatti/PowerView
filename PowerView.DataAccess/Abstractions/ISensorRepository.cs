using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.DataAccess.Abstractions
{
    public interface IControllerRepository
    {
        Controller Get(Int32 controllerID);

        IList<Controller> Get();
    }
}
