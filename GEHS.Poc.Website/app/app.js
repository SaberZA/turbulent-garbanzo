(function() {
    'use strict';

    var app = angular.module('gehs',
        ['mgcrea.ngStrap',
         'ui.router',
         'common.services']);

    app.config(['$stateProvider', '$urlRouterProvider', configRoutes]);

    function configRoutes($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/login');

        $stateProvider
            .state('login', {
                url: '/login',
                templateUrl: 'app/login/partial-login.html',
                controller: 'loginCtrl'
            })
            .state('user', {
                url: '/user',
                templateUrl: 'app/user/partial-user.html',
                controller: 'userCtrl'
            });
    };
}());