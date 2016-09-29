function OrdersDashboardModule($scope, $element, $q) {

    var self = this;

    $scope.selectedLocation = '00000000-0000-0000-0000-000000000000';

    self.onMessage = function(msg) {
        switch (msg.key) {
            case Core.Messenger.MESSAGE_TYPES.INITIALIZE:
                var promises = [];
                promises.push($scope.GetLocations());
                $scope.ReloadData(promises);
        }
    };

    $scope.ReloadData = function(promises)
    {
        promises = promises || [];

        $scope.ShowError = false;

        Core.Dialogs.BusyWorker.showBusy($element);
        
        promises.push($scope.GetOpenOrders());

        $q.all(promises).then(function (resolved) {
            Core.Dialogs.BusyWorker.hideBusy($element);
            $scope.FadeIn();
        }, function (reason) {
            Core.Dialogs.BusyWorker.hideBusy($element);
            $scope.ShowError = true;
        });
    }

    $scope.GetLocations = function () {

        var deferred = $q.defer();

        var inventoryService = new Services.InventoryService();

        inventoryService.getStockLocations(function (event) {
            if (event.hasErrors() == true) {
                deferred.reject(event.error);
            } else {
                $scope.Locations = event.result;
                deferred.resolve();
            }
        });

        return deferred.promise;
    }

    $scope.GetOpenOrders = function () {

        var deferred = $q.defer();

        var ordersService = new Services.OrdersService();

        var ordersArray = [];

        ordersService.getOpenOrders(
             10000,
             1,
             null,
             null,
             $scope.selectedLocation,
             '',
             function (event) {
                 if (event.hasErrors() == true) {
                     deferred.reject(event.error);
                 } else {

                     $scope.Orders = event.result.Data;
                     $scope.CalculateWidgetValues(event.result.Data);
                     $scope.$apply();
                     if (event.result.Data.length > 0) {
                         $scope.UpdateCharts(event.result.Data);
                     }

                     deferred.resolve();
                 }
             }
          );

        return deferred.promise;
    }

    $scope.FadeIn = function()
    {
        $("#orders-view").hide().animate({
            opacity: "toggle"
        }, 1000);
    }

    
    $scope.SplitDataAndCreateChart = function (id, type, label, dictionary) {

        var sources = [];
        var values = [];
        var colors = [];

        for (key in dictionary) {
            sources.push(key);
            values.push(dictionary[key]);
            colors.push($scope.GetRandomColor());
        }

        $scope.CreateChart(id, type, label, sources, values, colors);
    }

    $scope.CreateChart = function(id, type, label, labels, values, colors)
    {
        var context = $element.find("#" + id);

        if (context === undefined || context === null)
        {
            Core.Dialogs.addNotify("Couldn't find element for chart - " + id, 'ERROR');
            return;
        }

        var myChart = new Chart(context, {
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
    }
    
    $scope.DrawSourcesGraph = function(dictionary)
    {
        $scope.SplitDataAndCreateChart("sourcesChart", "pie", "# of orders", dictionary);
    }

    $scope.DrawRevenueGraph = function(dictionary)
    {
        $scope.SplitDataAndCreateChart("revenueChart", "doughnut", "# of orders", dictionary);
    }

    $scope.DrawShippingGraph = function(dictionary)
    {
        $scope.SplitDataAndCreateChart("shippingChart", "bar", "# of orders", dictionary);
    }

    $scope.UpdateCharts = function (orders) {
        var sourcesDictionary = {};
        var shippingDictionary = {};
        var revenueDictionary = {};

        // Iterate and load data
        for (var x = 0; x < orders.length; x++) {
            incrementPropertyCount(sourcesDictionary, orders[x].GeneralInfo.Source);

            incrementPropertyCount(shippingDictionary, orders[x].ShippingInfo.PostalServiceName);

            incrementPropertyCount(revenueDictionary, orders[x].TotalsInfo.Currency);
        }

        $scope.DrawShippingGraph(shippingDictionary);
        $scope.DrawSourcesGraph(sourcesDictionary);
        $scope.DrawRevenueGraph(revenueDictionary);
    }

    function incrementPropertyCount(dictionary, property) {
        if (dictionary.hasOwnProperty(property)) {
            dictionary[property] = dictionary[property] + 1;
        } else {
            dictionary[property] = 1;
        }
    }


    $scope.GetRandomColor = function()
    {
        return Please.make_color().toString();
    }

    $scope.CalculateWidgetValues = function(data)
    {
        $scope.OrdersInvoicesPrinted = 0;
        $scope.OrdersLabelsPrinted = 0;
        $scope.OrdersOnHold = 0;

        for(var x = 0; x < data.length; x++)
        {
            var i = data[x];

            if (i.GeneralInfo.HoldOrCancel === true)
            {
                $scope.OrdersOnHold++;
            }

            if(i.GeneralInfo.LabelPrinted === true)
            {
                $scope.OrdersLabelsPrinted++;
            }

            if (i.GeneralInfo.InvoicePrinted === true)
            {
                $scope.OrdersInvoicesPrinted++;
            }
        }
    }

    $scope.ViewOrder = function(order)
    {
        var width = $(window).width() - 200;
        width = Math.min(width, 910);
        var win = new Core.Window({
            moduleName: "OpenOrders",
            windowName: "OpenOrders_ViewOrder",
            width: width + "px",
            height: Math.min($(window).height() - 100, 1400) + "px",
            isBackDrop: true,
            data: {
                orderId: order,
                fulfillmentCenter: $scope.selectedLocation
            },
        }, self.options);
        win.open();
    }

}