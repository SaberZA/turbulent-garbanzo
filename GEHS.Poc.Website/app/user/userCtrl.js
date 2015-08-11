(function () {
    'use strict';

    angular.module('gehs')
        .controller('userCtrl',
        ['$scope', '$state', userCtrl]);

    function userCtrl($scope, $state) {
        $scope.firstName = "Steven";
        $scope.lastName = "van der Merwe";
        $scope.idNumber = "891000000";

    };
}());