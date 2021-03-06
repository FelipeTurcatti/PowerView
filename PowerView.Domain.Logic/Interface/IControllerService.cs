﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerView.DataAccess;

namespace PowerView.Domain.Logic.Interface
{
    public interface IControllerService
    {
        IEnumerable<Controller> Get();

        Controller GetByID(Int32 controllerID);

        void Insert(Controller controller);

        void Update(Controller controller);

        void Delete(Controller controller);

        void AddMetricController(Int32 controllerID,Int32 metricID);

        void RemoveMetricController(Int32 idController, Int32 idMetrica);
    }
      
}
