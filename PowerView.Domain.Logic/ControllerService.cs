﻿using PowerView.DataAccess.Abstractions;
using PowerView.Domain.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerView.DataAccess;

namespace PowerView.Domain.Logic
{
    public class ControllerService : IControllerService
    {
        private readonly IControllerRepository _controllerRepository;


        #region Constructor

        public ControllerService(IControllerRepository controllerRepository)
        {
            this._controllerRepository = controllerRepository;
        }

        #endregion

        public IEnumerable<Controller> Get()
        {
            return this._controllerRepository.Get();
        }

        public Controller GetByID(Int32 controllerID)
        {
            return this._controllerRepository.GetByID(controllerID);
        }

        public void Insert(Controller controller)
        {
            this._controllerRepository.Insert(controller);
        }

        public void Update(Controller controller)
        {
            this._controllerRepository.Update(controller);
        }


        public void Delete(Controller controller)
        {
            this._controllerRepository.Delete(controller);

        }


        public void AddMetricController(Int32 controllerID,Int32 metricID)
        {
            this._controllerRepository.AddMetricController(controllerID,metricID);
        }

        public void RemoveMetricController(Int32 idController,Int32 idMetrica)
        {
            this._controllerRepository.RemoveMetricController(idController, idMetrica);
        }
    }
}
