(function () {
    'use strict';
    angular.module('drm.reminder')
        .directive('drmReminderView', drmReminderView);

    drmReminderView.$inject = [];
    function drmReminderView() {
        return {
            restruct: 'E',
            templateUrl: '/js/reminder/reminder-view.tpl.html',
            controller: 'DrmReminderViewCtrl',
            controllerAs: 'vm',
            bindToController: {

            },
            scrope: {}
        };
    }
})();