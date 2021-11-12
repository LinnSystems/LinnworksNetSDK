using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TemplateProxyExample.Config;

namespace TemplateProxyExample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConfigController : BaseController
    {
        public ConfigController(IOptions<AppSettings> config) : base(config)
        {
        }

        [HttpPost]
        public Models.User.AddNewUserResponse AddNewUser([FromBody] Models.User.AddNewUserRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Email))
                return new Models.User.AddNewUserResponse { Error = "Invalid Email" };

            if (string.IsNullOrWhiteSpace(request.AccountName))
                return new Models.User.AddNewUserResponse { Error = "Invalid AccountName" };

            if (request.LinnworksUniqueIdentifier == Guid.Empty)
                return new Models.User.AddNewUserResponse { Error = "Invalid LinnworksUniqueIdentifier" };

            var userConfig = new Models.User.UserConfig(this.UserStoreLocation);

            userConfig.CreateNew(request.Email, request.LinnworksUniqueIdentifier, request.AccountName);

            return new Models.User.AddNewUserResponse
            {
                AuthorizationToken = userConfig.AuthorizationToken
            };
        }

        [HttpPost]
        public Models.BaseResponse ConfigDeleted([FromBody] Models.BaseRequest request)
        {
            try
            {
                var user = new Models.User.UserConfig(this.UserStoreLocation, request.AuthorizationToken);

                user.Delete();

                return new Models.BaseResponse();
            }
            catch (Exception ex)
            {
                return new Models.BaseResponse { Error = ex.Message };
            }
        }

        [HttpPost]
        public Models.BaseResponse ConfigTest([FromBody] Models.BaseRequest request)
        {
            try
            {
                var user = new Models.User.UserConfig(this.UserStoreLocation, request.AuthorizationToken);

                //Would normally do something here to test.

                return new Models.BaseResponse();
            }
            catch (Exception ex)
            {
                return new Models.BaseResponse { Error = ex.Message };
            }
        }

        [HttpPost]
        public Models.Payment.PaymentTagResponse PaymentTags([FromBody] Models.BaseRequest request)
        {
            try
            {
                var user = new Models.User.UserConfig(this.UserStoreLocation, request.AuthorizationToken);

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
            catch (Exception ex)
            {
                return new Models.Payment.PaymentTagResponse { Error = ex.Message };
            }
        }

        [HttpPost]
        public Models.Shipping.ShippingTagResponse ShippingTags([FromBody] Models.BaseRequest request)
        {
            try
            {
                var user = new Models.User.UserConfig(this.UserStoreLocation, request.AuthorizationToken);

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
            catch (Exception ex)
            {
                return new Models.Shipping.ShippingTagResponse { Error = ex.Message };
            }
        }

        [HttpPost]
        public Models.User.UserConfigResponse UserConfig([FromBody] Models.BaseRequest request)
        {
            try
            {
                var userConfig = new Models.User.UserConfig(this.UserStoreLocation, request.AuthorizationToken);
                var configSetp = new Models.User.ConfigStages(userConfig);

                return configSetp.StageResponse("User config is at invalid stage");
            }
            catch (Exception ex)
            {
                return new Models.User.UserConfigResponse { Error = ex.Message };
            }
        }

        [HttpPost]
        public Models.User.UserConfigResponse SaveConfigSave([FromBody] Models.User.SaveUserConfigRequest request)
        {
            try
            {
                var userConfig = new Models.User.UserConfig(this.UserStoreLocation, request.AuthorizationToken);

                if (request.StepName != userConfig.StepName)
                    return new Models.User.UserConfigResponse { Error = string.Format("Invalid step name expected {0}", userConfig.StepName) };

                return userConfig.Save(request.ConfigItems);
            }
            catch (Exception ex)
            {
                return new Models.User.UserConfigResponse { Error = ex.Message };
            }
        }
    }
}
