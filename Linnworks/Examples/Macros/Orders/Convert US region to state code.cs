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
        public void Execute(Guid[] OrderIds)
        {
            Logger.WriteDebug("Starting macro");
            
            Logger.WriteInfo($"Loading details for {OrderIds.Length} orders");
            var orderDetails = LoadOrderDetails(OrderIds);

            if (orderDetails.Count > 0)
            {
                foreach (var order in orderDetails)
                {
                    var regionCode = GetCodeFromRegion(order.CustomerInfo.Address.Region);
                    if (!regionCode.Equals(order.CustomerInfo.Address.Region, StringComparison.OrdinalIgnoreCase))
                    {
                        order.CustomerInfo.Address.Region = regionCode;
                        SaveUpdatedRegion(order);
                    }
                }
            }
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

        private void SaveUpdatedRegion(OrderDetails order)
        {
            try
            {
                Api.Orders.SetOrderCustomerInfo(order.OrderId, order.CustomerInfo, false);
            }
            catch (Exception ex)
            {
                Logger.WriteError($"Got error '{ex.Message}' when updating region");
            }
        }

        private string GetCodeFromRegion(string region)
        {
            if (RegionsAndCodes.ContainsKey(region))
            {
                return RegionsAndCodes[region];
            }

            return region;
        }

        private Dictionary<string, string> RegionsAndCodes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Alabama", "AL" },
            { "Alaska", "AK" },
            { "Arizona", "AZ" },
            { "Arkansas", "AR" },
            { "California", "CA" },
            { "Colorado", "CO" },
            { "Connecticut", "CT" },
            { "Delaware", "DE" },
            { "District of Columbia", "DC" },
            { "Florida", "FL" },
            { "Georgia", "GA" },
            { "Hawaii", "HI" },
            { "Idaho", "ID" },
            { "Illinois", "IL" },
            { "Indiana", "IN" },
            { "Iowa", "IA" },
            { "Kansas", "KS" },
            { "Kentucky", "KY" },
            { "Louisiana", "LA" },
            { "Maine", "ME" },
            { "Maryland", "MD" },
            { "Massachusetts", "MA" },
            { "Michigan", "MI" },
            { "Minnesota", "MN" },
            { "Mississippi", "MS" },
            { "Missouri", "MO" },
            { "Montana", "MT" },
            { "Nebraska", "NE" },
            { "Nevada", "NV" },
            { "New Hampshire", "NH" },
            { "New Jersey", "NJ" },
            { "New Mexico", "NM" },
            { "New York", "NY" },
            { "North Carolina", "NC" },
            { "North Dakota", "ND" },
            { "Ohio", "OH" },
            { "Oklahoma", "OK" },
            { "Oregon", "OR" },
            { "Pennsylvania", "PA" },
            { "Rhode Island", "RI" },
            { "South Carolina", "SC" },
            { "South Dakota", "SD" },
            { "Tennessee", "TN" },
            { "Texas", "TX" },
            { "Utah", "UT" },
            { "Vermont", "VT" },
            { "Virginia", "VA" },
            { "Washington", "WA" },
            { "West Virginia", "WV" },
            { "Wisconsin", "WI" },
            { "Wyoming", "WY" },

            { "Alberta", "AB" },
            { "British Columbia", "BC" },
            { "Manitoba", "MB" },
            { "New Brunswick", "NB" },
            { "Newfoundland and Labrador", "NL" },
            { "Nova Scotia", "NS" },
            { "Northwest Territories", "NT" },
            { "Nunavut", "NU" },
            { "Ontario", "ON" },
            { "Prince Edward Island", "PE" },
            { "Quebec", "QC" },
            { "Saskatchewan", "SK" },
            { "Yukon", "YT" },

            { "New South Wales", "NSW" },
            { "Australian Capital Territory", "ACT" },
            { "Victoria", "VIC" },
            { "Queensland", "QLD" },
            { "South Australia", "SA" },
            { "Western Australia", "WA" },
            { "Tasmania", "TAS" },
            { "Northern Territory", "NT" }
        };
    }
}