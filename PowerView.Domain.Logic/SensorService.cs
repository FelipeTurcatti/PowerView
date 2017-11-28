using PowerView.DataAccess.Abstractions;
using PowerView.Domain.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Controller GetController(Int32 controllerID)
        {
            return this._controllerRepository.Get(controllerID);
        }

        public IList<Controller> GetControllers()
        {
            return this._controllerRepository.Get();
        }
    }
}
