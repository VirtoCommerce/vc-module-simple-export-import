angular.module('virtoCommerce.priceExportImportModule')
.controller('virtoCommerce.priceExportImportModule.importProcessingController', ['$scope', 'virtoCommerce.priceExportImportModule.import', 'platformWebApp.assets.api', 'platformWebApp.bladeNavigationService',
    function ($scope, importResources, assetsApi, bladeNavigationService) {
        var blade = $scope.blade;
        blade.isLoading = false;

        $scope.$on("new-notification-event", function (event, notification) {
            if (blade.notification && notification.id === blade.notification.id) {
                angular.copy(notification, blade.notification);
            }
        });

        blade.toolbarCommands = [{
            name: 'platform.commands.cancel',
            icon: 'fa fa-times',
            canExecuteMethod: function() {
                return blade.notification && !blade.notification.finished;
            },
            executeMethod: function() {
                importResources.cancel({ jobId: blade.notification.jobId });
            }
        }];

        $scope.bladeClose = () => {
            if (blade.notification.reportUrl) {
                assetsApi.remove({urls: [blade.notification.reportUrl]},
                    () => { },
                    (error) => bladeNavigationService.setError('Error ' + error.status, blade)
                );
            }

            if (blade.notification.finished) {
                bladeNavigationService.closeChildrenBlades(blade.parentBlade.parentBlade.parentBlade, function () { });
            }
            else {
                bladeNavigationService.closeBlade(blade);
            }
        }

    }]);
