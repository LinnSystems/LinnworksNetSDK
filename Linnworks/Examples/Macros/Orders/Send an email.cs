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
using LinnworksMacroHelpers.Classes.Email;

namespace LinnworksMacro
{
    public class LinnworksMacro : LinnworksMacroHelpers.LinnworksMacroBase
    {
        /// <summary>
        /// The entry point for this macro, this function will be executed and its result returned when the macro is run
        /// </summary>
        /// <param name="OrderIds">An array of GUID order IDs on which to perform operations (passed when a rules engine rule executes a macro)</param>
        /// <param name="host">The e-mail server hostname</param>
        /// <param name="port">The e-mail server port</param>
        /// <param name="ysername">The username to log into the e-mail server</param>
        /// <param name="password">The password to log into the e-mail server</param>
        /// <param name="emailSubject">The subject line for the e-mail to send</param>
        /// <param name="emailBody">The body for the e-mail to send</param>
        /// <param name="isHTML">Determines whether the e-mail should be parsed as HTML</param>
        public void Execute(Guid[] OrderIds, string host, int port, string username, string password, string emailSubject, string emailBody, bool isHTML)
        {
            Logger.WriteDebug("Starting macro");

            foreach (var orderId in OrderIds)
            {
                Logger.WriteInfo($"Working on order with GUID ID '{orderId}'");

                var email = GetCustomerEmailAddress(orderId);

                if (string.IsNullOrWhiteSpace(email))
                {
                    Logger.WriteDebug("E-mail was not populated for customer");
                    return;
                }

                var settings = new EmailSettings()
                {
                    Host = host,
                    Username = username,
                    Password = password,
                    Port = port,
                    EnableSsl = true
                };
                
                var request = new ProxiedEmailRequest()
                {
                    BodyEncoding = "UTF-8",
                    Body = emailBody,
                    Settings = settings,
                    From = settings.Username,
                    IsBodyHtml = isHTML,
                    Sender = settings.Username,
                    SubjectEncoding = "UTF-8",
                    Subject = emailSubject,
                    To = new List<EmailAddress>{new EmailAddress{Address = email}}
                };

                try
                {
                    var result = ProxyFactory.SendEmail(request);
                
                    if (result.IsError)
                        Logger.WriteError("Email result = " + result.Error);
                    else
                        Logger.WriteInfo("Email sent");
                }
                catch (Exception ex)
                {
                    Logger.WriteError($"Failed to send e-mail with error '{ex.Message}'");
                }
            }
            
            Logger.WriteDebug("Macro complete");
        }

        private string GetCustomerEmailAddress(Guid orderId)
        {
            var query = $"SELECT cEmailAddress [Open_Order] WHERE pkOrderId = '{orderId}'";

            try
            {
                var result = Api.Dashboards.ExecuteCustomScriptQuery(new ExecuteCustomScriptQueryRequest()
                    {Script = query});

                if (result != null && !result.IsError && result.Results.Count > 0)
                {
                    return result.Results.First()["cEmailAddress"]?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                Logger.WriteError($"Failed to retrieve customer e-mail address with error '{ex.Message}'");
            }

            return null;
        }

        private void CreateOrderSplit(Guid orderId, OrderFulfillmentCentreAndPostalService additionalInfo, List<ItemAndOptions> items)
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
                Api.Orders.SplitOrder(orderId, new OrderSplit[] {split}, "Extended Property Split",
                    additionalInfo.FulfillmentLocation.Value);
            }
            catch (Exception ex)
            {
                Logger.WriteError($"Failed to split order with error '{ex.Message}'");
            }
        }

        class ItemAndOptions
        {
            public Guid RowId { get; set; }
            public int Quantity { get; set; }
            public bool IsLinked { get; set; }
            public List<OrderItemOption> ExtendedProperties { get; set; }
        }

        class OrderFulfillmentCentreAndPostalService
        {
            public Guid? FulfillmentLocation { get; set; }
            public Guid? PostalService { get; set; }
        }
    }
}