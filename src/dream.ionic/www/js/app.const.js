(function () {
    'use strict';
    angular.module('dream')
        .constant('drmAppConst', getAppConst());

    function getAppConst() {
        return {
            apiRoot: 'http://localhost:5050/api/'
        };
    }
})();