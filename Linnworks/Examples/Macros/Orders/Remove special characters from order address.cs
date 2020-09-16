using LinnworksAPI;
using LinnworksMacroHelpers.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        /// <param name="MacroSpecialCharacterRemoverSettings">A complex object that is passed through as a JSON string parameter, containing settings for the macro</param>
        public void Execute(Guid[] OrderIds, MacroSpecialCharacterRemoverSettings settings)
        {
            Logger.WriteDebug("Starting macro");

            if (settings == null)
            {
                Logger.WriteError("Empty or invalid settings object passed, exiting");
                return;
            }
            
            Logger.WriteInfo($"Loading details for {OrderIds.Length} orders");
            var orderDetails = LoadOrderDetails(OrderIds);
            
            if (orderDetails.Count > 0)
            {
                foreach (var order in orderDetails)
                {
                    SetNewAddress(order, settings);
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

        private void SetNewAddress(OrderDetails order, MacroSpecialCharacterRemoverSettings settings)
        {
            Logger.WriteInfo($"Working on order {order.OrderId}");

            var customerAddress = order.CustomerInfo.Address;

            if (customerAddress == null)
            {
                Logger.WriteDebug($"Could not load address details for order with ID {order.OrderId}");
                return;
            }

            bool changesMade = false;

            if (settings.RemoveFromCompanyName)
            {
                customerAddress.Company = RemoveSpecialCharacters(customerAddress.Company, changesMade: ref changesMade);
            }

            if (settings.RemoveFromCustomerName)
            {
                customerAddress.FullName = RemoveSpecialCharacters(customerAddress.FullName, ref changesMade);
            }

            if (settings.RemoveFromAddressLines)
            {
                customerAddress.Address1 = RemoveSpecialCharacters(customerAddress.Address1, ref changesMade);
                customerAddress.Address2 = RemoveSpecialCharacters(customerAddress.Address2, ref changesMade);
                customerAddress.Address3 = RemoveSpecialCharacters(customerAddress.Address3, ref changesMade);
            }

            if (settings.RemoveFromTownAndRegion)
            {
                customerAddress.Town = RemoveSpecialCharacters(customerAddress.Town, ref changesMade);
                customerAddress.Region = RemoveSpecialCharacters(customerAddress.Region, ref changesMade);
            }

            if (settings.RemoveFromCountry)
            {
                customerAddress.Country = RemoveSpecialCharacters(customerAddress.Country, ref changesMade);
            }

            if (changesMade)
            {
                Logger.WriteInfo("Changes made, updating order");
                try
                {
                    Api.Orders.SetOrderCustomerInfo(order.OrderId, order.CustomerInfo, false);
                }
                catch (Exception ex)
                {
                    Logger.WriteError($"Failed to update customer address with error '{ex.Message}'");
                }
            }
        }

        private string RemoveSpecialCharacters(string input, ref bool changesMade)
        {
            string normalizedInput = input.Normalize(NormalizationForm.FormD);
            StringBuilder builder = new StringBuilder();

            foreach (var character in normalizedInput)
            {
                var category = CharUnicodeInfo.GetUnicodeCategory(character);
                switch (category)
                {
                    case UnicodeCategory.LowercaseLetter:
                    case UnicodeCategory.UppercaseLetter:
                    case UnicodeCategory.SpaceSeparator:
                    case UnicodeCategory.DecimalDigitNumber:
                        builder.Append(character);
                        break;
                    default:
                        break;
                }
            }

            var resultString = builder.ToString();

            if (!changesMade)
            {
                changesMade = !resultString.Equals(input);
            }

            return resultString;
        }
    }

    public class MacroSpecialCharacterRemoverSettings
    {
        /// <summary>
        /// Determines whether to remove special characters from the company name
        /// </summary>
        public bool RemoveFromCompanyName { get; set; }
        
        /// <summary>
        /// Determines whether to remove special characters from the customer name
        /// </summary>
        public bool RemoveFromCustomerName { get; set; }
        
        /// <summary>
        /// Determines whether to remove special characters from the address lines
        /// </summary>
        public bool RemoveFromAddressLines { get; set; }
        
        /// <summary>
        /// Determines whether to remove special characters from the delivery town and region
        /// </summary>
        public bool RemoveFromTownAndRegion { get; set; }
        
        /// <summary>
        /// Determines whether to remove special characters from the delivery country
        /// </summary>
        public bool RemoveFromCountry { get; set; }
    }
}