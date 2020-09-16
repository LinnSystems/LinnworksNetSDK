using LinnworksAPI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinnworksMacro
{
    public class LinnworksMacro : LinnworksMacroHelpers.LinnworksMacroBase
    {
        /// <summary>
        /// The entry point for this macro, this function will be executed and its result returned when the macro is run
        /// </summary>
        /// <param name="OrderIds">An array of GUID order IDs on which to perform operations (passed when a rules engine rule executes a macro)</param>
        /// <param name="addressMaxLength">Set the max length for an address line</param>
        public void Execute(Guid[] OrderIds, int addressMaxLength)
        {
            Logger.WriteDebug("Starting macro");

            Logger.WriteInfo($"Loading details for {OrderIds.Length} orders");
            var orderDetails = LoadOrderDetails(OrderIds);

            if (orderDetails.Count > 0)
            {
                foreach (var order in orderDetails)
                {
                    GetNewAddress(order, addressMaxLength);
                }
            }
            
            Logger.WriteDebug("Macro complete");
        }

        private List<OrderDetails> LoadOrderDetails(Guid[] orderIds)
        {
            try
            {
                return Api.Orders.GetOrdersById(orderIds.ToList());
            }
            catch (Exception ex)
            {
                Logger.WriteError($"Got error '{ex.Message}' when loading order details");
                return new List<OrderDetails>();
            }
        }

        private void GetNewAddress(OrderDetails order, int maxLength)
        {
			Logger.WriteInfo($"Working on order {order.OrderId}");
			
            var customerAddress = order.CustomerInfo.Address;

            if (customerAddress == null)
            {
                Logger.WriteDebug($"Could not load address details for order with ID {order.OrderId}");
                return;
            }
            
            bool addressLine1IsLong = IsTooLong(customerAddress.Address1, maxLength)
            string restOfAddressLine1 = "";

            if (addressLine1IsLong)
            {
                Logger.WriteDebug("Address line 1 too long, trimming");
                var cutOffAddressLine1 = customerAddress.Address1.Substring(0, maxLength);
                restOfAddressLine1 = customerAddress.Address1.Substring(maxLength).Trim();

                customerAddress.Address1 = cutOffAddressLine1;
                customerAddress.Address2 = string.Concat(restOfAddressLine1, customerAddress.Address2);
            }

            bool addressLine2IsLong = IsTooLong(customerAddress.Address2, maxLength);
            string restOfAddressLine2 = "";

            if (addressLine2IsLong)
            {
                Logger.WriteDebug("Address line 2 is too long, trimming");
                var cutOffAddressLine2 = customerAddress.Address2.Substring(0, maxLength);
                restOfAddressLine2 = customerAddress.Address2.Substring(maxLength).Trim();

                customerAddress.Address2 = cutOffAddressLine2;
                customerAddress.Address3 = string.Concat(restOfAddressLine2, customerAddress.Address3);
            }

            bool addressLine3IsLong = IsTooLong(customerAddress.Address3, maxLength);

            if (addressLine3IsLong)
            {
                Logger.WriteDebug("Address line 3 is too long, trimming");
                customerAddress.Address3 = customerAddress.Address3.Substring(0, maxLength);
            }

            if (addressLine1IsLong || addressLine2IsLong || addressLine3IsLong)
            {
                Logger.WriteInfo("Saving order with updated address");
                try
                {
                    Api.Orders.SetOrderCustomerInfo(order.OrderId, order.CustomerInfo, false);
                }
                catch (Exception ex)
                {
                    Logger.WriteError($"Could not update order address with error '{ex.Message}'");
                }
            }
            else
            {
                Logger.WriteDebug("No changes needed");
            }
        }

        private bool IsTooLong(string input, int maxLength)
        {
            return input.Length > maxLength;
        }
    }
}