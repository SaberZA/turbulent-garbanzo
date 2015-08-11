(function () {
    "use strict";

    angular
        .module("common.services")
        .factory("loginResource",
        [
            "$resource",
            "appSettings",
            loginResource
        ]);

    function loginResource($resource, appSettings) {
        return $resource(appSettings.serverPath + "/api/login");
    };
}());