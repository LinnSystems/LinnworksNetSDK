using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TemplateProxyExample.Controllers
{
    public class ConfigController : ApiController
    {
        [HttpPost()]
        [ActionName("AddNewUser")]
        public Models.User.AddNewUserResponse AddNewUser(Models.User.AddNewUserRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Email))
                return new Models.User.AddNewUserResponse { Error = "Invalid Email" };

            if (string.IsNullOrWhiteSpace(request.AccountName))
                return new Models.User.AddNewUserResponse { Error = "Invalid AccountName" };

            if (request.LinnworksUniqueIdentifier == Guid.Empty)
                return new Models.User.AddNewUserResponse { Error = "Invalid LinnworksUniqueIdentifier" };

            return new Models.User.AddNewUserResponse
            {
                AuthorizationToken = Models.User.UserConfig.CreateNew(request.Email, request.LinnworksUniqueIdentifier, request.AccountName).AuthorizationToken
            };
        }

        [HttpPost]
        [ActionName("ConfigDeleted")]
        public Models.BaseResponse ConfigDeleted(Models.BaseRequest request)
        {
            try
            {
                var user = Models.User.UserConfig.Load(request.AuthorizationToken);

                if (user == null)
                    return new Models.BaseResponse { Error = "User not found" };

                Models.User.UserConfig.Delete(request.AuthorizationToken);

                return new Models.BaseResponse();
            }
            catch (Exception ex)
            {
                return new Models.BaseResponse { Error = ex.Message };
            }
        }

        [HttpPost]
        [ActionName("ConfigTest")]
        public Models.BaseResponse ConfigTest(Models.BaseRequest request)
        {
            try
            {
                var user = Models.User.UserConfig.Load(request.AuthorizationToken);

                if (user == null)
                    return new Models.BaseResponse { Error = "User not found" };

                //Would normally do something here to test.

                return new Models.BaseResponse();
            }
            catch (Exception ex)
            {
                return new Models.BaseResponse { Error = ex.Message };
            }
        }

        [HttpPost()]
        [ActionName("PaymentTags")]
        public Models.Payment.PaymentTagResponse PaymentTags(Models.BaseRequest request)
        {
            var user = Models.User.UserConfig.Load(request.AuthorizationToken);

            if (user == null)
                return new Models.Payment.PaymentTagResponse { Error = "User not found" };

            return new Models.Payment.PaymentTagResponse
            {
                PaymentTags = new[]
                {
                    new Models.Payment.PaymentTag { FriendlyName = "PayPal",  Site = "", Tag = "paypal_verified" },
                    new Models.Payment.PaymentTag { FriendlyName = "Credit Card - Master Card",  Site = "", Tag = "mastercard" },
                    new Models.Payment.PaymentTag { FriendlyName = "Credit Card - Visa",  Site = "", Tag = "visa_credit" },
                    new Models.Payment.PaymentTag { FriendlyName = "Credit Card - Unknown",  Site = "", Tag = "credit_unknown" },
                    new Models.Payment.PaymentTag { FriendlyName = "Bank payments",  Site = "", Tag = "bank" },
                }
            };
        }

        [HttpPost()]
        [ActionName("ShippingTags")]
        public Models.Shipping.ShippingTagResponse ShippingTags(Models.BaseRequest request)
        {
            var user = Models.User.UserConfig.Load(request.AuthorizationToken);

            if (user == null)
                return new Models.Shipping.ShippingTagResponse { Error = "User not found" };

            return new Models.Shipping.ShippingTagResponse
            {
                ShippingTags = new[]
                {
                    new Models.Shipping.ShippingTag { FriendlyName = "Royal Mail First Class",  Site = "", Tag = "RM CLR01" },
                    new Models.Shipping.ShippingTag { FriendlyName = "Royal Mail Special Delivery",  Site = "", Tag = "RM_SpecialDelivery_9am" },
                    new Models.Shipping.ShippingTag { FriendlyName = "DPD - Next Day",  Site = "", Tag = "dpd" },
                    new Models.Shipping.ShippingTag { FriendlyName = "Fedex - Ground",  Site = "", Tag = "fedex_ground" },
                    new Models.Shipping.ShippingTag { FriendlyName = "Some other service",  Site = "", Tag = "matrix_rate_10221" },
                }
            };
        }

        [HttpPost]
        [ActionName("UserConfig")]
        public Models.User.UserConfigResponse UserConfig(Models.BaseRequest request)
        {
            var userConfig = Models.User.UserConfig.Load(request.AuthorizationToken);

            if (userConfig == null)
                return new Models.User.UserConfigResponse { Error = "User not found" };

            if (userConfig.StepName == "AddCredentials")
            {
                return Models.User.ConfigStages.GetAPICredentials(userConfig);
            }
            else if (userConfig.StepName == "OrderSetup")
            {
                return Models.User.ConfigStages.GetOrderStep(userConfig);
            }
            else if (userConfig.StepName == "UserConfig")
            {
                return Models.User.ConfigStages.GetConfigStep(userConfig);
            }
            else return new Models.User.UserConfigResponse { Error = "User config is at invalid stage" };
        }

        [HttpPost]
        [ActionName("SaveUserConfig")]
        public Models.User.UserConfigResponse SaveConfigSave(Models.User.SaveUserConfigRequest request)
        {
            var userConfig = Models.User.UserConfig.Load(request.AuthorizationToken);

            if (userConfig == null)
                return new Models.User.UserConfigResponse { Error = "User not found" };

            if (request.StepName != userConfig.StepName)
                return new Models.User.UserConfigResponse { Error = string.Format("Invalid step name expected {0}", userConfig.StepName) };

            if (userConfig.StepName == "AddCredentials")
            {
                userConfig.APIKey = request.ConfigItems.FirstOrDefault(s => s.ConfigItemId == "APIKey");
                userConfig.APISecretKey = request.ConfigItems.FirstOrDefault(s => s.ConfigItemId == "APISecretKey");
                userConfig.IsOauth = request.ConfigItems.FirstOrDefault(s => s.ConfigItemId == "IsOauth");
                userConfig.StepName = "OrderSetup";

            }
            else if (userConfig.StepName == "OrderSetup")
            {
                userConfig.PriceIncTax = request.ConfigItems.FirstOrDefault(s => s.ConfigItemId == "PriceIncTax");
                userConfig.DownloadVirtualItems = request.ConfigItems.FirstOrDefault(s => s.ConfigItemId == "DownloadVirtualItems");
                userConfig.StepName = "UserConfig";
            }
            else if (userConfig.StepName == "UserConfig")
            {
                userConfig.IsOauth = request.ConfigItems.FirstOrDefault(s => s.ConfigItemId == "IsOauth");
                userConfig.PriceIncTax = request.ConfigItems.FirstOrDefault(s => s.ConfigItemId == "PriceIncTax");
                userConfig.DownloadVirtualItems = request.ConfigItems.FirstOrDefault(s => s.ConfigItemId == "DownloadVirtualItems");
            }

            userConfig.Save();

            if (userConfig.StepName == "AddCredentials")
            {
                return Models.User.ConfigStages.GetAPICredentials(userConfig);
            }
            else if (userConfig.StepName == "OrderSetup")
            {
                return Models.User.ConfigStages.GetOrderStep(userConfig);
            }
            else if (userConfig.StepName == "UserConfig")
            {
                return Models.User.ConfigStages.GetConfigStep(userConfig);
            }
            else return new Models.User.UserConfigResponse { };
        }
    }
}
