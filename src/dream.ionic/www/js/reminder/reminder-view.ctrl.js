(function () {
    'use strict';
    angular.module('drm.reminder')
        .controller('DrmReminderViewCtrl', DrmReminderViewCtrl);

    DrmReminderViewCtrl.$inject = ['drmReminderResrc'];
    function DrmReminderViewCtrl(drmReminderResrc) {
        var vm = this;

        drmReminderResrc
            .getAllReminders()
            .$promise
            .then(function (response) {
                vm.data = response;
            });
    }
})();