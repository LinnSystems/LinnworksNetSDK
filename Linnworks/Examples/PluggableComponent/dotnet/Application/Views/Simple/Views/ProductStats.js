function ProductStatsView($scope, $element, $q, $timeout) {

    var self = this;
    $scope.ChartHandles = {};

    self.onMessage = function(msg) {
        switch (msg.key) {
            case Core.Messenger.MESSAGE_TYPES.INITIALIZE:
                Core.Dialogs.BusyWorker.showBusy($element);
                $scope.Item = msg.data.data.Item;
                $scope.Initialize();
        }
    };

    $scope.Initialize = function()
    {

        var promises = [];
        promises.push($scope.GetStockLevels());
        
        $q.all(promises).then(function (resolved) {
            Core.Dialogs.BusyWorker.hideBusy($element);
            $scope.Loaded = true;
            $scope.$apply();
            $scope.LoadCharts();
        }, function (reason) {
            Core.Dialogs.BusyWorker.hideBusy($element);
            $scope.ShowError = true;
        });        
    }

    $scope.GetStockLevels = function()
    {
        var deferred = $q.defer();

        var stockService = new Services.StockService();
        stockService.GetStockLevel($scope.Item.Id, function (event) {
            if (event.hasErrors() === true) {
                deferred.reject(event.error);
            } else {
                $scope.Locations = event.result;
                deferred.resolve();
            }
        });

        return deferred.promise;
    }

    $scope.ViewProduct = function () {
        var win = new Core.Window({
            moduleName: "MyInventory",
            windowName: "MyInventory_EditInventoryItem",
            data: {
                itemId: $scope.Item.Id
            },
            closeOnEscape: false,
            closeOnBackDrop: false
        }, self.options).open();
    }

    $scope.GetRandomColor = function () {
        return Please.make_color().toString();
    }

    $scope.GetRandomColors = function (amount) {
        var r = [];
        for(var x = 0; x < amount; x++)
        {
            r.push($scope.GetRandomColor());
        }

        return r;
    }

    $scope.LoadCharts = function()
    {
        $scope.LoadOverallChart();
        $scope.LoadLocationCharts();
    }

    $scope.LoadLocationCharts = function()
    {
        for(var x = 0; x < $scope.Locations.length; x++)
        {
            var location = $scope.Locations[x];
            $scope.CreateChart(location.Location.StockLocationId, "pie", "", ["Available", "Due", "In Orders", "Level"], [location.Available, location.Due, location.InOrders, location.StockLevel], $scope.GetRandomColors(4));
        }
    }

    $scope.LoadOverallChart = function()
    {
        $scope.CreateChart("overallChart", "pie", "", ["Available", "Due", "In Orders", "Level"], [$scope.Item.Available, $scope.Item.Due, $scope.Item.InOrder, $scope.Item.StockLevel], $scope.GetRandomColors(4));
    }

    $scope.CreateChart = function (id, type, label, labels, values, colors) {
        var context = $element.find("#" + id);
        
        var handle = $scope.ChartHandles[id];

        if (handle != null) {
            handle.destroy();
            $scope.ChartHandles[id] = null;
        }

        if (context === undefined || context === null) {
            Core.Dialogs.addNotify("Couldn't find element for chart - " + id, 'ERROR');
            return;
        }

        var newChart = new Chart(context, {
            type: type,
            data: {
                labels: labels,
                datasets: [{
                    label: label,
                    data: values,
                    borderWidth: 1,
                    backgroundColor: colors
                }]
            }
        });

        $scope.ChartHandles[id] = newChart;
    }

    $scope.Close = function()
    {
        self.close();
    }
}