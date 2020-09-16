using LinnworksAPI;
using LinnworksMacroHelpers.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LinnworksMacro
{
    public class LinnworksMacro : LinnworksMacroHelpers.LinnworksMacroBase
    {
        /// <summary>
        /// The entry point for this macro, this function will be executed and its result returned when the macro is run
        /// </summary>
        /// <param name="OrderIds">An array of GUID order IDs on which to perform operations (passed when a rules engine rule executes a macro)</param>
        /// <param name="supplierName">The name of the supplier that, if it is the default supplier for the item, will split the order</param>
        public void Execute(Guid[] OrderIds, string supplierName)
        {
            Logger.WriteDebug("Starting macro");

            var allSuppliers = GetSuppliers();

            if (allSuppliers.Count == 0)
            {
                Logger.WriteDebug("No suppliers found, exiting");
                return;
            }

            foreach (var orderId in OrderIds)
            {
                Logger.WriteInfo($"Working on order with GUID ID '{orderId}'");
                var orderAdditionalInfo = GetOrderPostalServiceAndFulfillmentLocation(orderId);

                if (!orderAdditionalInfo.FulfillmentLocation.HasValue)
                {
                    Logger.WriteError("Could not determine order fulfillment location, exiting");
                    return;
                }
                
                var itemSuppliers = LoadOrderItemSuppliers(orderId, orderAdditionalInfo.FulfillmentLocation.Value);

                var itemsToSplit = GetToSplitList(itemSuppliers, allSuppliers, supplierName);

                if (itemsToSplit.Count == 0 || itemsToSplit.Count == itemSuppliers.Count)
                {
                    Logger.WriteDebug("No items to split, exiting");
                    return;
                }

                if (orderAdditionalInfo.PostalService.HasValue)
                {
                    CreateOrderSplit(orderId, orderAdditionalInfo, itemsToSplit);
                }
            }
            
            Logger.WriteDebug("Macro complete");
        }

        private List<Supplier> GetSuppliers()
        {
            var retVal = new List<Supplier>();
            
            try
            {
                retVal = Api.Inventory.GetSuppliers();
            }
            catch (Exception ex)
            {
                Logger.WriteError($"Got an error when retrieving all suppliers: '{ex.Message}'");
            }

            return retVal;
        }

        private List<ItemAndSupplier> LoadOrderItemSuppliers(Guid orderId, Guid locationId)
        {
            var retVal = new List<ItemAndSupplier>();
            
            try
            {
                var items = Api.Orders.GetOrderItems(orderId, locationId);
                var suppliers = Api.Orders.GetOpenOrderItemsSuppliers(orderId);

                foreach (var item in items)
                {
                    var foundItem = suppliers.FirstOrDefault(s => s.Key == item.RowId);

                    if (foundItem.Key == item.RowId)
                    {
                        retVal.Add(new ItemAndSupplier()
                        {
                            RowId = item.RowId,
                            Quantity = item.Quantity,
                            IsLinked = !(item.IsService || item.IsUnlinked) && item.StockItemId != Guid.Empty,
                            Supplier = foundItem.Value
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteError(ex.Message);
            }

            return retVal;
        }

        private List<ItemAndSupplier> GetToSplitList(List<ItemAndSupplier> input, List<Supplier> allSuppliers, string supplierName)
        {
            var output = new List<ItemAndSupplier>();
                
            foreach (var itemAndSupplier in input)
            {
                if (!itemAndSupplier.IsLinked)
                    continue;
                
                var foundSupplier = allSuppliers.FirstOrDefault(s => s.pkSupplierID == itemAndSupplier.Supplier)?.SupplierName;

                if (!string.IsNullOrWhiteSpace(foundSupplier) &&
                    foundSupplier.Equals(supplierName, StringComparison.OrdinalIgnoreCase))
                {
                    output.Add(itemAndSupplier);
                }
            }
            
            return output;
        }

        private OrderFulfillmentCentreAndPostalService GetOrderPostalServiceAndFulfillmentLocation(Guid orderId)
        {
            var query = $"SELECT fkPostalServiceId, fkLocationId FROM [Open_Order] WHERE pkOrderId = '{orderId}'";
            var retVal = new OrderFulfillmentCentreAndPostalService();

            try
            {
                var result = Api.Dashboards.ExecuteCustomScriptQuery(new ExecuteCustomScriptQueryRequest()
                    {Script = query});

                if (result != null && !result.IsError && result.Results.Count > 0)
                {
                    var ps = Guid.Parse(result.Results.First()["fkPostalServiceId"].ToString());
                    var fulfillment = Guid.Parse(result.Results.First()["fkLocationId"].ToString());

                    retVal.FulfillmentLocation = fulfillment;
                    retVal.PostalService = ps;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteError($"Failed to retrieve postal service with error '{ex.Message}'");
            }

            return retVal;
        }

        private void CreateOrderSplit(Guid orderId, OrderFulfillmentCentreAndPostalService additionalInfo, List<ItemAndSupplier> items)
        {
            List<OrderSplitOutItem> splitItems = new List<OrderSplitOutItem>();
            
            foreach (var item in items)
            {
                splitItems.Add(new OrderSplitOutItem()
                {
                    RowId = item.RowId,
                    Quantity = item.Quantity
                });
            }

            var split = new OrderSplit()
            {
                Items = splitItems,
                PostalServiceId = additionalInfo.PostalService.Value
            };

            try
            {
                Api.Orders.SplitOrder(orderId, new OrderSplit[] {split}, "Supplier Split",
                    additionalInfo.FulfillmentLocation.Value);
            }
            catch (Exception ex)
            {
                Logger.WriteError($"Failed to split order with error '{ex.Message}'");
            }
        }

        class ItemAndSupplier
        {
            public Guid RowId { get; set; }
            public int Quantity { get; set; }
            public bool IsLinked { get; set; }
            public Guid Supplier { get; set; }
        }

        class OrderFulfillmentCentreAndPostalService
        {
            public Guid? FulfillmentLocation { get; set; }
            public Guid? PostalService { get; set; }
        }
    }
}