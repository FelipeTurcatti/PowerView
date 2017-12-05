using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerView.Domain.Logic.Interface
{
    public interface IMetricService
    {

        IEnumerable<Metric> Get();

        Metric GetByID(Int32 controllerID);

        void Insert(Metric controller);

        void Update(Metric controller);

        void Delete(Metric controller);
    }
}
