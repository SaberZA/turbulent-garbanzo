(function() {
    'use strict';

    angular.module('gehs')
        .controller('loginCtrl',
        ['$scope','$state','loginResource', loginCtrl]);

    function loginCtrl($scope, $state, loginResource) {
        $scope.userName = 'stevenv';

        $scope.login = function() {
            var postLogin = $scope.userName;

            loginResource.query(function (data) {
                $scope.logins = data;

                var validLogin = _.find($scope.logins, function (login) { return login.userName.toLowerCase() == postLogin.toLowerCase(); });

                if (validLogin) {
                    $state.go('user');
                }
            });
        };

    };
}());