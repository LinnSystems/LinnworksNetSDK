// edit item
var firstPlaceHolder = function ($scope, $element) {
    this.getItems = function () {
        var items = [{
            key: "productStats",
            text: "Product Stock Stats",
            icon: "fa fa-bar-chart func"
        }];

        return items;
    }

    //this.validatePermissions = function (itemKey) {
    //    return true;
    //}

    this.isEnabled = function (itemKey) {
        switch (itemKey) {
            case "productStats":
                return $scope.selectedRowsCount == 1;
        }

        return;
    }

    this.onClick = function (itemKey, $event) {
        var gridScope = $element.find(".inventoryItemsGrid").scope();

        switch (itemKey) {
            case "productStats":
                new Core.Window({
                    windowName: 'ProductStats',
                    moduleName: 'ProductStats',
                    data: { Item: gridScope.getSelectedItem()  },
                    onWindowClosed: function (event) {
                       
                    }
                }).open();
                break;
        }
    }
}


Core.PlaceHolderManager.register({
    moduleName: "MyInventory",
    placeHolderName: "MyInventory_RightTopButtons"
}, firstPlaceHolder);


// Right top context menu
Core.PlaceHolderManager.register({
    moduleName: "MyInventory",
    placeHolderName: "MyInventory_RightTopContextMenu"
}, firstPlaceHolder);


// Grid context menu
Core.PlaceHolderManager.register({
    moduleName: "MyInventory",
    placeHolderName: "MyInventory_GridContextMenu"
}, firstPlaceHolder);
