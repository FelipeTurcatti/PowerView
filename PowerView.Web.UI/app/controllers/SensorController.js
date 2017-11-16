(function () {
  'use strict';

  angular
      .module('app')
      .controller('SensorController', SensorController);

  function SensorController(SensorService) {

    var vm = this;

    /*SensorService.getSensors()
      .then(function (data) {
        vm.sensors = data;
      });*/
    vm.sensors = SensorService.getSensors();

  }

})();