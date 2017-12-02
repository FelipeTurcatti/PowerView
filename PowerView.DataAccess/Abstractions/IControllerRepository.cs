using PowerView.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace PowerView.DataAccess.Abstractions
{
    public interface IControllerRepository
    {
        IEnumerable<Controller> Get(
             Expression<Func<Controller, Boolean>> filter = null,
             Func<IQueryable<Controller>, IOrderedQueryable<Controller>> orderBy = null,
             String includeProperties = "");

        Controller GetByID(Object id);

        void Insert(Controller controller);
              
        void Update(Controller controller);
        
        void Delete(Controller controller);

      

    }
}
