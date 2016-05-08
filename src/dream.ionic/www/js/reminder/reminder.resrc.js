(function () {
    'use strict';
    angular.module('drm.reminder')
        .factory('drmReminderResrc', drmReminderResrc);

    drmReminderResrc.$inject = ['$resource', 'drmAppConst'];
    function drmReminderResrc($resource, drmAppConst) {
        var apiUrl = drmAppConst.apiRoot + 'reminder/';
        return $resource(apiUrl, null, {
            getAllReminders: {
                method: 'GET',
                url: apiUrl + 'GetAllReminders',
                isArray: true,
                params: {}
            }
        });
    }
})();