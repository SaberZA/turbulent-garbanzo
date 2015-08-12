(function () {
    "use strict";

    angular.module("common.services",
        ["ngResource"])
    .constant("appSettings",
    {
        serverPath: "http://gehspoc.azurewebsites.net"
    });
}());