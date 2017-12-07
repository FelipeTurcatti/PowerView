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

        public void AddMetricController(Int32 controllerID,Int32 metricID)
        {
            Controller controller = this.GetByID(controllerID);

            Metric metric = new Metric { MetricId = metricID };

            this.context.Metrics.Attach(metric);

            controller.Metrics.Add(metric);

            this.context.SaveChanges();                
        }
        public void RemoveMetricController(Int32 controllerID, Int32 metricID)
        {
            Controller controller = this.GetByID(controllerID);
                        
            Metric metric = controller.Metrics.FirstOrDefault(e => e.MetricId == metricID);

            controller.Metrics.Remove(metric);

            this.Update(controller);

            //context.Entry(controller.Metrics).State = EntityState.Deleted;
            
            this.context.SaveChanges();
        }

        #region Methods
        #endregion
    }
}
