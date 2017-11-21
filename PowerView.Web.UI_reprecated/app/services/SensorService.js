(function () {
  'use strict';

  angular
  .module('app')
  .factory('SensorService', SensorService);

  function SensorService($http, $rootScope) {

    var service = {
      getSensors: getSensors
    };

    return service;

    function getSensors() {

      /* var uri = "";

      return $http({
        url: uri,
        method: "GET",
        headers: {
                "Content-Type": "application/json"
            }
        }).then(function (response) {
            return response.data;
        }); */

      return [
        { Name: "S1", Description: "Sensor 1" },
        { Name: "S2", Description: "Sensor 2" }
      ];

    }
  }
})();
